using System;
public class Area
{
    public double CalculatedArea;
    public double Pie;
    public double Radius;

    public void AreaCalculation()
    {
        Console.WriteLine("Area is = "+ CalculatedArea);
    }

}

public class CircleArea : Area
{

}
public class CylinderArea : Area
{
    public double Height;
}
public class Program
{
    public static void Main()
    {
        CircleArea CircleAreaObj = new CircleArea();
        CircleAreaObj.Pie = 3.14;
        CircleAreaObj.Radius = 10;
        CircleAreaObj.CalculatedArea = CircleAreaObj.Pie * (CircleAreaObj.Radius * CircleAreaObj.Radius);
        CircleAreaObj.AreaCalculation();

        CylinderArea CylinderAreaObj = new CylinderArea();
        CylinderAreaObj.Pie = 3.14;
        CylinderAreaObj.Radius = 10;
        CylinderAreaObj.Height = 5;
        CylinderAreaObj.CalculatedArea = CylinderAreaObj.Pie * (CylinderAreaObj.Radius * CylinderAreaObj.Radius) * CylinderAreaObj.Height;
        CylinderAreaObj.AreaCalculation();

    }
}
