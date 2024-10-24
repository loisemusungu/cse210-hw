using System;

public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;
    protected bool _isComplete = false;

    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public Goal()
    {}

    public abstract void  RecordEvent(GoalManager goalManager);

    public abstract bool IsComplete();

    public void MarkComplete()
    {
        _isComplete = true; // Add a method to mark the goal as complete
    }

    public virtual void GetDetailsString()
    {}

    public abstract string GetStringRepresentation();
}