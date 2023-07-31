using System;

class Calculator
{
    double myValue;

    public Calculator()
    {
        myValue = 0; // Constructor to set default value for myValue
    }

    public Calculator(double value)
    {
        myValue = value; // Constructor to set value for myValue
    }

    public void setValue(double value)
    {
        myValue = value;
    }

    public void square()
    {
        Console.WriteLine($"Square: {myValue * myValue}");
    }

    public void qube()
    {
        Console.WriteLine($"Cube: {myValue * myValue * myValue}");
    }
}

class Program
{
    static void Main()
    {
        Calculator calc1 = new Calculator(5);
        calc1.square();
        calc1.qube();

        Calculator calc2 = new Calculator();
        calc2.square(); // Will print garbage values due to default value of myValue
        calc2.qube(); // Will print garbage values due to default value of myValue
    }
}
