using System;
using System.Threading;

public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void run()
    {
        DisplayStartingMessage();

        ShowSpinner();

    // User specifies the duration
    int duration = GetDuration();
    DateTime endTime = DateTime.Now.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
        Console.WriteLine($"Breathe in... ");  // Countdown for 5 seconds)
        ShowCountDown(); // Countdown for 5 seconds
        if (DateTime.Now >= endTime) break; // Check if time is up

        Console.WriteLine("Breathe out... ");
        ShowCountDown(); // Countdown for 5 seconds
        if (DateTime.Now >= endTime) break; // Check if time is up
    }

        Console.WriteLine("This activity is now complete.");
        ShowSpinner();
        Console.WriteLine(DisplayEndingMessage());
    }

}