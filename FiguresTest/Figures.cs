using System.Formats.Asn1;

namespace FiguresTest;

    public abstract class Shape
    {
        protected string name;
        public Shape(string n1 = "Shape") 
        {
            name = n1; 
        }
        
        public virtual void Display() 
        { 
            Console.WriteLine(name); 
        }

        public abstract double Perimeter(); 
        public abstract double Area(); 
    }

    public class Triangle : Shape 
    { 
        
        double _side1, _side2, _side3; 
        public double Side1
        {
            get => _side1;
            set 
            {
                if (value < 0)
                    _side1 = -value;
                else _side1 = value;
            }
        }
        public double Side2
        {
            get => _side2;
            set
            {
                if (value < 0)
                    _side2 = -value;
                else _side2 = value;
            }
        }
        public double Side3
        {
            get => _side3;
            set
            {
                if (value < 0)
                    _side3 = -value;
                else _side3 = value;
            }
        }
        
        public Triangle() : base("Triangle")
        {
            Side1 = 3;
            Side2 = 4;
            Side3 = 5;
        } 
 
        public Triangle(double s1, double s2, double s3) : base("Triangle")
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }

        public bool IsTriangleExists()
        {
            if (Side1 + Side2 > Side3 & Side1 + Side3 > Side2 & Side2 + Side3 > Side1)
                return true;
            return false;
        }
        
        public bool IsRight()
        {
            if (Side1*Side1==Side2*Side2+Side3*Side3 || Side2*Side2==Side1*Side1+Side3*Side3 || Side3*Side3==Side1*Side1+Side2*Side2)
                return true;
            return false;
        }
 
        public override double Area()  
        { 
            double p = Perimeter()/2;
            // Console.WriteLine("half p= "+p);
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3)); 
        } 
        public override double Perimeter()  
        {
            return Side1+Side2+Side3;
        } 
        public override void Display() 
        {
            Console.WriteLine("Shape: "+name + "\n Side 1 length=" + Side1 + "\n Side 2 length=" + Side2 + "\n Side 3 length=" + Side3); 
        }
    }

    public class Circle : Shape
    {
        double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                    _radius = -value;
                else _radius = value;
            }
        }
        public Circle(double r) : base("Circle")
        {
            Radius = r;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Display() 
        {
            Console.WriteLine("Shape: "+name + "\n Radius =" + Radius); 
        } 
        
    }
    