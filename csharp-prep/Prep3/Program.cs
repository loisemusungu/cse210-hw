using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int guesses = 0;

        // Generate a random number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessInt = int.Parse(guess);
        
        
        while (guessInt != magicNumberInt)
        {
            guesses++;

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

        guesses++;
        
        // Print the success message after exiting the loop
        Console.WriteLine($"You guessed the magic number in {guesses} guesses!");
    }
}
