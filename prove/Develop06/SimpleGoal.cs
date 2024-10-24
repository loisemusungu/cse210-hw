using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        SetShortName(Console.ReadLine());
        
        Console.Write("What is the description of your goal? ");
        SetDescription(Console.ReadLine());
        
        int points;
        while (true)
        {
            Console.Write("How many points is your goal worth? ");
            if (int.TryParse(Console.ReadLine(), out points))
            {
                SetPoints(points);
                break; // Exit the loop if parsing is successful
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for points.");
            }
        }
    }
    
    public override void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine($"Event recorded for goal: {GetShortName()}");
        MarkComplete(); // Mark the goal as complete when an event is recorded
    }

    public override bool IsComplete() // Implement your completion logic
    {
        return _isComplete;
    }

    public override string GetStringRepresentation() 
    {
        return $"{(IsComplete() ? "[x]" : "[ ]")} {GetShortName()} - {GetDescription()} ({GetPoints()} points)";
    }
}
