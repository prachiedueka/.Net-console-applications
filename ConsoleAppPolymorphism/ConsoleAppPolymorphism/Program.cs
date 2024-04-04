using System;
using System.Globalization;
public class Shape
{
    public string IsShape = "None";
    public double Pie;
    public double Radius;

    public virtual void ShowShape()
    {
        Console.WriteLine("Shape is = " + IsShape);
    }

}

public class RectangleShape : Shape
{
    public string IsShape = "Rectangle";
    public override void ShowShape()
    {
        Console.WriteLine("Shape is = " + IsShape);
    }
}
public class TriangleShape : Shape
{
    public string IsShape = "Triangle";
    public override void ShowShape()
    {
        Console.WriteLine("Shape is = " + IsShape);
    }
}
public class Program
{
    public static void Main()
    {
        Shape[] Shapelist = new Shape[2];
        Shapelist[0] = new RectangleShape();
        Shapelist[1] = new TriangleShape();
        foreach(Shape s in Shapelist)
        {
            s.ShowShape();
        }

    }
}

