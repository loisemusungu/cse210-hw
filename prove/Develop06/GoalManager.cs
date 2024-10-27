using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("Player Score: " + _score);
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            // Use the string representation specific to each goal type
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your selection: ");
        string goalSelection = Console.ReadLine();

        if (goalSelection == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            _goals.Add(simpleGoal);
        }
        else if (goalSelection == "2")
        {
            EternalGoal eternalGoal = new EternalGoal();
            _goals.Add(eternalGoal);
        }
        else if (goalSelection == "3")
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.Write("Enter your selection: ");
        int goalSelection = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalSelection >= 0 && goalSelection < _goals.Count)
        {
            _goals[goalSelection].RecordEvent(this); // Pass the current GoalManager instance
            AddPoints(_goals[goalSelection].GetPoints()); // Add points here
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    public void AddPoints(int points)
    {
        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal)
                    writer.WriteLine("SimpleGoal");
                else if (goal is EternalGoal)
                    writer.WriteLine("EternalGoal");
                else if (goal is ChecklistGoal)
                    writer.WriteLine("ChecklistGoal");

                writer.WriteLine(goal.GetShortName());
                writer.WriteLine(goal.GetDescription());
                writer.WriteLine(goal.GetPoints());
                writer.WriteLine(goal.IsComplete() ? "true" : "false"); // Save completion status
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the name of the file to load goals from (e.g., goals.txt): ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("No saved goals found with that filename.");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                string shortName = reader.ReadLine();
                string description = reader.ReadLine();
                int points = Convert.ToInt32(reader.ReadLine());

                Goal goal = null;
                if (goalType == "SimpleGoal")
                {
                    goal = new SimpleGoal();
                }
                else if (goalType == "EternalGoal")
                {
                    goal = new EternalGoal();
                }
                else if (goalType == "ChecklistGoal")
                {
                    goal = new ChecklistGoal();
                }

                if (goal != null)
                {
                    goal.SetShortName(shortName);
                    goal.SetDescription(description);
                    goal.SetPoints(points);
                    _goals.Add(goal); // Add to the existing list
                }
            }
        }
    }
}
