using System;
using System.Collections.Generic;

public class Exercise
{
    protected int _distance = 0;
    protected int _time = 0;
    protected DateTime currentDate = DateTime.Now;

    public int GetDistance()
    {
        return _distance;
    }

    public void SetDistance(int distance)
    {
        _distance = distance;
    }

    public int GetTime()
    {
        return _time;
    }

    public void SetTime(int time)
    {
        _time = time;
    }

    public double GetSpeed()
    {
        return (double)(_distance / _time) * 60;
    }

    public double GetPace()
    {
        return (double)_time / _distance;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{currentDate} ({_time} min) - Distance {_distance} miles, Speed {GetSpeed()} mph, Pace {GetPace()} minutes per mile");

    }
}