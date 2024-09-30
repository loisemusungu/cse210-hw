public class Fraction
{
    private int _numerator;
    private int _denominator;

    private string _divider;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 5;
        _divider = "/";

    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public Fraction(int numerator, string divider, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
        _divider = divider;
    }

    public string GetFractionString()
    {
        return _numerator + _divider + _denominator;
    }

    public void SetFractionString(int numerator, string divider, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
        _divider = divider;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }

    public void SetDecimalValue(double value)
    {
        _numerator = (int)(value * 100);
        _denominator = 100;
    }
}