using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string selection ="";

        while (selection != "6")
        {
            Console.WriteLine("You have 0 points.");
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

            if (selection == "1")
            {
                Console.WriteLine("What type of goal would you like to create?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Enter your selection: ");
                string goalSelection = Console.ReadLine();

                if (goalSelection == "1" )
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                }
                else if (goalSelection == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                }
                else if (goalSelection == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }
            else if (selection == "2")
            {
                goalManager.ListGoalNames();
            }
            else if (selection == "3")
            {
                goalManager.SaveGoals();
            }
            else if (selection == "4")
            {
                goalManager.LoadGoals();
    
            }
            else if (selection == "5")
            {
                goalManager.RecordEvent();
            }
            else if (selection == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }
    }
}