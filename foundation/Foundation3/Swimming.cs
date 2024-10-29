using System;

public class Swimming : Exercise
{
    private double _laps;

    public Swimming(double laps, double time)
    {
        _laps = laps;
        _time = time;
        _distance = GetDistance(); // This sets _distance based on laps
    }

    public override double GetDistance()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return Math.Round(_laps * 50 / 1000, 2);
    }

    public override void GetSummary()
    {
        string formattedDate = currentDate.ToString("dd MMM yyyy");
        Console.WriteLine($"{formattedDate} Swimming ({_time} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kmh, Pace {GetPace()} minutes per km");
    }
}