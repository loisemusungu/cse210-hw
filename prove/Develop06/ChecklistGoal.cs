using System;

public class ChecklistGoal : Goal
{
    public ChecklistGoal()
    {
        SetShortName("Checklist Goal");
        SetDescription("This is an eternal goal that you can use to test the goal system.");
        SetPoints(0);
    }
    
    public override void RecordEvent()
    {}

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