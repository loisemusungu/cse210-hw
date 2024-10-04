using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6); // Handles multiple verses
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");  

        // Step 2: Main loop for user interaction
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear(); // Step 3: Clear the console
            Console.WriteLine(scripture.GetFullDisplayText()); // Show the scripture (reference + text)
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break; // Exit the loop if the user types 'quit'
            }

            scripture.HideRandomWords(4); // Hide 4 random words each time
        }

        Console.Clear(); // Clear the console one last time when all words are hidden
        Console.WriteLine("Goodbye!");
    }

}