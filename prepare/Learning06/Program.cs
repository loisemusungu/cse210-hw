using System;
using System.Collections.Generic;

//Polymorphism

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);
        Rectangle rectangle = new Rectangle(5, 10);
        Circle circle = new Circle(5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }
    }
}