using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        activity.SetDuration(10);
        activity.ShowSpinner();
        activity.ShowCountDown();
        Console.WriteLine("Hello Develop05 World!");
    }
}