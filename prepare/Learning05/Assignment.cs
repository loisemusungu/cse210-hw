using System;
using System.Collections.Generic;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public string GetSummary()
    {
        return $"{_studentName} is working on {_topic}";
    }
}