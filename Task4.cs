using System;

class Circle
{
    private double radius;

    public void setRadius(double r)
    {
        radius = r;
    }

    public void showCircumference()
    {
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine($"Circumference of Circle: {circumference}");
    }

    public void showArea()
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of Circle: {area}");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.setRadius(5);
        circle.showCircumference();
        circle.showArea();
    }
}
