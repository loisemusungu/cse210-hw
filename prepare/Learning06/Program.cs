using System;
using System.Collections.Generic;

//Polymorphism

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);
        square.SetColor("Red");
        Rectangle rectangle = new Rectangle(5, 10);
        rectangle.SetColor("Blue");
        Circle circle = new Circle(5);
        circle.SetColor("Green");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area is {shape.GetArea()} and has a color of {shape.GetColor()}");
    
        }
    }
}