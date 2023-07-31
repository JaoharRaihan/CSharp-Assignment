using System;

class Student
{
    private string name;
    private string id;
    private double cgpa;

    public Student(string n, string i, double c)
    {
        name = n;
        id = i;
        cgpa = c;
    }

    public double CGPA
    {
        get { return cgpa; }
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("John", "12345", 3.8);
        Student student2 = new Student("Alice", "67890", 3.6);

        double averageCGPA = (student1.CGPA + student2.CGPA) / 2;
        Console.WriteLine($"Average CGPA: {averageCGPA}");
    }
}
