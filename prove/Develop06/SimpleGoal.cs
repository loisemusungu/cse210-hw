using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        SetShortName("Simple Goal");
        SetDescription("This is a simple goal that you can use to test the goal system.");
        SetPoints(0);
    }
    
    public override void RecordEvent()
    {}

    public override bool IsComplete()
    {
        return false;
    }

    public override void GetStringRepresentation()
    {}
}