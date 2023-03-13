namespace FiguresUnitTests;

public class FiguresTests
{
    [Fact]
    public void CircleConstructor_RadiusLessThenZero_ReturnAsGreaterThenZero()
    {
        Circle cr = new Circle(-5);

        Assert.True(cr.Radius>0);
    }

    [Fact]
    public void TriangleConstructor_SidesLessThenZero_ReturnsAsGreaterThenZero()
    {
        Triangle tr = new Triangle(-5, -4, -3);
        
        Assert.True(tr.Side1>0);
        Assert.True(tr.Side2>0);
        Assert.True(tr.Side3>0);
    }

    [Fact]
    public void TriangleConstructor_TriangleData_ReturnTriangle()
    {
        
        Triangle tr = new Triangle(6, 5, 4);
        
        Assert.True(tr.Side1==6);
        Assert.True(tr.Side2==5);
        Assert.True(tr.Side3==4);
    }
    
    [Fact]
    public void TriangleIsRight_RightTriangle_ReturnTrue()
    {
        Triangle tr = new Triangle(5, 4, 3);
        
        Assert.True(tr.IsRight());
    }
    
    [Fact]
    public void TriangleIsRight_NotRightTriangle_ReturnFalse()
    {
        Triangle tr = new Triangle(10, 4, 3);
        
        Assert.False(tr.IsRight());
    }

    [Fact]
    public void IsTriangleExist_GoodData_ReturnsTrue()
    {
        Triangle tr = new Triangle(5, 4, 3);
        
        Assert.True(tr.IsTriangleExists());
    }
    [Fact]
    public void IsTriangleExist_BadData_ReturnsFalse()
    {
        Triangle tr = new Triangle(10, 4, 3);
        
        Assert.False(tr.IsTriangleExists());
    }
}