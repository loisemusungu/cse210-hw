using System;

public class Exercise
{
    protected double _distance = 0;
    protected double _time = 0;
    protected DateTime currentDate = DateTime.Now; 

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual void SetDistance(double distance)
    {
        _distance = distance;
    }

    public double GetTime()
    {
        return _time;
    }

    public void SetTime(double time)
    {
        _time = time;
    }

    public virtual double GetSpeed()
    {
        return Math.Round((_distance / _time) * 60, 2);
    }

    public virtual double GetPace()
    {
        return Math.Round(_time / _distance, 2);
    }

    public virtual void GetSummary()
    {
    
    }
}