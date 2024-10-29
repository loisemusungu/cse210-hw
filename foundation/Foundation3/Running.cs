using System;

public class Running : Exercise
{
    public Running(int distance, int time)
    {
        SetDistance(distance);
        SetTime(time);
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{currentDate} Running ({_time} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} minutes per mile");
    }
}