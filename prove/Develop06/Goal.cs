using System;

public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;

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

    public virtual void GetDetailsString()
    {}

    public abstract string GetStringRepresentation();
}