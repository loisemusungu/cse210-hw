/* 
Loise Musungu
CSE 210

To exceed requirements, I have added a scripture library to allow 
this program to randomly select scripture for the user to memorize 
and I have modified the HideRandomWords function in scripture
class to allow the program to select words to hide from the ones that 
have not been hidden 
*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Psalms", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture(new Reference("Psalms", 100, 1, 2), "Make a joyful noise to the Lord, all the earth! Serve the Lord with gladness! Come into his presence with singing!")
        };

        Random random = new Random();

        while (true) // Loop through the entire program
        {
            Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            while (!selectedScripture.IsCompletelyHidden())
            {
                Console.Clear(); // Clear the console
                Console.WriteLine(selectedScripture.GetFullDisplayText()); // Show the scripture (reference + text)
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return; // End the program
                }

                selectedScripture.HideRandomWords(3); // Hide 3 random words
            }

            Console.Clear(); // Clear the console when all words in a scripture are hidden
            Console.WriteLine("All words for this scripture are hidden. Moving to the next scripture...");
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            
            string nextInput = Console.ReadLine();
            if (nextInput.ToLower() == "quit")
            {
                return; // End the program
            }
        }
    }

}