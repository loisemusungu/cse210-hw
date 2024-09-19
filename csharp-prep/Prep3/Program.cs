using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magicNumberInt = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessInt = int.Parse(guess);
        

        if (guessInt == magicNumberInt)
        {
            Console.WriteLine("You guessed the magic number!");
        }
        if (guessInt < magicNumberInt)
        {
            Console.WriteLine("Higher.");
        }
        if (guessInt > magicNumberInt)
        {
            Console.WriteLine("Lower.");
        }
    }
}