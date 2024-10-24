using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(GoalManager goalManager)
    {
        Console.Write("What is the name of your goal? ");
        SetShortName (Console.ReadLine());
        Console.Write("What is the description of your goal? ");
        SetDescription (Console.ReadLine());
        Console.Write("How many points is your goal worth? ");
        SetPoints(Convert.ToInt32(Console.ReadLine()));
    }
    
    public override void RecordEvent(GoalManager goalManager)
    {
        goalManager.AddPoints(_points);
        Console.WriteLine($"Event recorded for {GetShortName()}. You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void GetStringRepresentation()
    {
        
    }
}