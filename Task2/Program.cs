var circle = new Circle(123);
System.Console.Write("Circle = ");

System.Console.WriteLine(circle.SetRadius(Convert.ToDouble(Console.ReadLine())));

System.Console.WriteLine(circle.GetRadius());

System.Console.WriteLine(circle.GetArea());

System.Console.WriteLine(circle.GetDiameter());

System.Console.WriteLine(circle.GetCircumference());
class Circle
{
    private double radius;
    private double Pi;

    public Circle(double Radius)
    {
      radius = Radius;  
    }
    public Circle() {}
    public string SetRadius(double _radius)
    {
        radius=_radius;
        return $"{radius}";
    }
    public string GetRadius()
    {
        return $"{radius}";
    }
    public string GetArea()
    {
        return $"Area = {3.14159*Math.Pow(radius,2)}";
    }
    public string GetDiameter()
    {
        return $"Diametr = {radius * 2}";
    }
    public string GetCircumference()
    {
        return $"Circumference = {2 * 3.14159 * radius}";
    }
}