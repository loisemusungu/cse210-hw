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
        
        while (guessInt != magicNumberInt)
        {
            if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("Lower.");
            }
            
            // Request another guess
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
        }
        
        // Print the success message after exiting the loop
        Console.WriteLine("You guessed the magic number!");
    }
}
