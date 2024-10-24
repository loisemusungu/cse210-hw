using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        SetShortName("Simple Goal");
        SetDescription("This is a simple goal that you can use to test the goal system.");
        SetPoints(0);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is the description of your goal? ");
        string goalDescription = Console.ReadLine();
        Console.Write("How many points is your goal worth? ");
        int goalPoints = Convert.ToInt32(Console.ReadLine());
    }
    
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void GetStringRepresentation()
    {}
}