using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string selection = "";

        while (selection != "6")
        {
            goalManager.DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a new Goal");
            Console.WriteLine("2. List your Goals");
            Console.WriteLine("3. Save your Goals");
            Console.WriteLine("4. Load your Goals");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your selection: ");
            selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}
