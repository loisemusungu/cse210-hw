public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _timesAccomplished;
    private int _requiredCompletions;

    public ChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        SetShortName(Console.ReadLine());
        
        Console.Write("What is the description of your goal? ");
        SetDescription(Console.ReadLine());
        
        int points;
        while (true)
        {
            Console.Write("How many points is your goal worth? ");
            if (int.TryParse(Console.ReadLine(), out points))
            {
                SetPoints(points);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for points.");
            }
        }

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _requiredCompletions = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = Convert.ToInt32(Console.ReadLine());

        _timesAccomplished = 0; // Start with 0 accomplishments
    }

    public override void RecordEvent(GoalManager goalManager)
    {
        _timesAccomplished++;
        if (_timesAccomplished < _requiredCompletions)
        {
            goalManager.AddPoints(_points);
            Console.WriteLine($"Event recorded for {GetShortName()}. You earned {_points} points. Progress: {_timesAccomplished}/{_requiredCompletions}");
        }
        else if (_timesAccomplished == _requiredCompletions)
        {
            goalManager.AddPoints(_points + _bonus);
            Console.WriteLine($"Event recorded for {GetShortName()}. You completed the goal and earned {_points} points and a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"Goal {GetShortName()} has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _timesAccomplished >= _requiredCompletions;
    }

    public override string GetStringRepresentation()
    {
        // Adding the progress to the string representation
        return $"{(IsComplete() ? "[x]" : "[ ]")} {GetShortName()} ({GetDescription()}) -- Currently: {_timesAccomplished}/{_requiredCompletions}";
    }
}
