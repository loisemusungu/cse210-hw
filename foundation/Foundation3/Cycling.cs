using System;

public class Cycling : Exercise
{
    public Cycling(double distance, double time)
    {
        SetDistance(distance);
        SetTime(time);
    }

    public override void GetSummary()
    {
        string formattedDate = currentDate.ToString("dd MMM yyyy");
        Console.WriteLine($"{formattedDate} Cycling ({_time} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kmh, Pace {GetPace()} minutes per km");
    }
}