using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator thePromptGenerator = new PromptGenerator();

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Add a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Load journal entries from a file");
            Console.WriteLine("4. Save journal entries to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = thePromptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, response);
                    theJournal.AddEntry(newEntry);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the name of the file to load: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("Enter the name of the file to save: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
    }
}