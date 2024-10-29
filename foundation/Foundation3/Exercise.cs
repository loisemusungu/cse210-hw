using System;
using System.Collections.Generic;

public class Exercise
{
    protected double _distance = 0;
    protected double _time = 0;
    protected DateTime currentDate = DateTime.Now; 

    public double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
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
        return (_distance / _time) * 60;
    }

    public virtual double GetPace()
    {
        return _time / _distance;
    }

    public virtual void GetSummary()
    {
    
    }
}