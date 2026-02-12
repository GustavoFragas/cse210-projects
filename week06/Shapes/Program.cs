using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(2.5, "red"),
            new Rectangle(3, 4, "blue"),
            new Square(5, "green")
        };

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"{s.GetType().Name} (color: {s.GetColor()}) area = {s.GetArea():F2}");
        }
    }
}