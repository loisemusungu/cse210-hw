using System;

// calculating the area of the rectangle

public class Rectangle: Shape
{
    private double _length = 0;
    private double _width = 0;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}