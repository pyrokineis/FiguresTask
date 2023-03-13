// See https://aka.ms/new-console-template for more information
using FiguresTest;

Triangle tr = new Triangle(15, 17, 13);
tr.Display();
Console.WriteLine(tr.IsTriangleExists());
Console.WriteLine(tr.IsRight().ToString());
Console.WriteLine(tr.Area());

Circle cr = new Circle(5);
cr.Display();
Console.WriteLine(cr.Perimeter());
Console.WriteLine(cr.Area());


Shape shape = null;
switch (Console.ReadLine().ToLower())
{
    case "1": shape = new Circle(5);
        break;
    case "2": shape = new Triangle(3, 4, 5);
        break;
}
Console.WriteLine(shape.Area());
