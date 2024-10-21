using System;

// This is the base class for calculating ares for all shapes

public class Shape
{
    protected string _color;

    public shapes()
        {
        }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}