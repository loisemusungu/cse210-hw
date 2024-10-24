using System;

public class ChecklistGoal : Goal
{
    public ChecklistGoal()
    {
        SetShortName("Checklist Goal");
        SetDescription("This is an eternal goal that you can use to test the goal system.");
        SetPoints(0);
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

    public override void GetDetailsString()
    {
       
    }

    public override void GetStringRepresentation()
    {}
}