using System;

public class Math : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic} in section {_textbookSection} and has to do problems {_problems}";
    }
}