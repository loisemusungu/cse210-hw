using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("John");
        assignment1.SetTopic("C#");
        
        Console.WriteLine(assignment1.GetSummary());
    }
}