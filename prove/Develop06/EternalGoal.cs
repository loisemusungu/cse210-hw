using System;

public class EternalGoal : Goal
{
    public EternalGoal()
    {
        SetShortName("Eternal Goal");
        SetDescription("This is an eternal goal that you can use to test the goal system.");
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