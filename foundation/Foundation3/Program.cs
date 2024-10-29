using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(new Running(3, 30));
        exercises.Add(new Cycling(10, 60));
        exercises.Add(new Swimming(5, 120));


        foreach (Exercise exercise in exercises)
        {
            exercise.GetSummary();
        }
    }
}