using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade in percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        string letter = "";

        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course.");
        }
    }
}