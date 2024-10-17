using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. QUIT");

        Console.Write("Enter your selection: ");
        string selection = Console.ReadLine();

        if (selection == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.run();
        }
        else if (selection == "2")
        {
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.run();
        }
        else if (selection == "3")
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.run();
        }
        else if (selection == "4")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    
    }
}