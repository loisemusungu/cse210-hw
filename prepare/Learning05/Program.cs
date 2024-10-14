using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Mary Waters");
        assignment1.SetTopic("European History");

        Writing writing1 = new Writing();
        writing1.SetTitle("The Causes of World War II");
        writing1.SetStudentName("Mary Waters");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}