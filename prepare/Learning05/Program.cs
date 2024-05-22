using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>(); 

        Square square = new Square("Red", 4);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        shapes.Add(square);

        Retangle retangle = new Retangle("Green", 7, 2);
        Console.WriteLine(retangle.GetColor());
        Console.WriteLine(retangle.GetArea());
        shapes.Add(retangle);

        Circle circle = new Circle("Red", 4);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"Color: {color} area: {area}");
        }
    }
}