using System;

public class Running : Exercise
{
    public Running(double distance, double time)
    {
        SetDistance(distance);
        SetTime(time);
    }

    public override void GetSummary()
    {
        string formattedDate = currentDate.ToString("dd MMM yyyy");
        Console.WriteLine($"{formattedDate} Running ({_time} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kmh, Pace {GetPace()} minutes per km");
    }
}