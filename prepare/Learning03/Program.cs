using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(3, 4);
        Fraction f3 = new Fraction(3, "/", 4);
        
        Console.WriteLine(f1);
        Console.WriteLine(f2);
        Console.WriteLine(f3);

        Console.ReadLine();
    }
}