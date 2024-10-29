using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(new Running(3, 30));
        exercises.Add(new Running(5.5, 45));

        foreach (Exercise exercise in exercises)
        {
            exercise.GetSummary();
        }
    }
}