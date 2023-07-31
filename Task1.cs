using System;

class Rectangle
{
    private int width, height;

    public void setWidth(int w)
    {
        width = w;
    }

    public void setHeight(int h)
    {
        height = h;
    }

    public int getWidth()
    {
        return width;
    }

    public int getHeight()
    {
        return height;
    }

    public void showArea()
    {
        int area = width * height;
        Console.WriteLine($"Area of Rectangle: {area}");
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle1 = new Rectangle();
        rectangle1.setWidth(5);
        rectangle1.setHeight(10);
        rectangle1.showArea();

        Rectangle rectangle2 = new Rectangle();
        rectangle2.setWidth(8);
        rectangle2.setHeight(12);
        rectangle2.showArea();

        Rectangle rectangle3 = new Rectangle();
        rectangle3.showArea(); // Will print garbage values due to unset width and height

        // Using constructor to initialize width and height
        Rectangle rectangle4 = new Rectangle();
        rectangle4.showArea(); // Will now print a meaningful area
    }
}
