using System;

public class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _score = 0;

    public string GetGoalsString()
    {
        string goalsString = "";
        foreach (Goal goal in _goals)
        {
            goalsString += goal.GetShortName() + ": " + goal.GetDescription() + "\n";
        }
        return goalsString;
    }

    public int GetScore()
    {
        return _score;
    }

    public GoalManager()
    {}
    
    public void Start()
    {}

    public void DisplayPlayerInfo()
    {}

    public void ListGoalNames()
    {}

    public void ListGoalDetails()
    {}

    public void CreateGoal()
    {}

    public void RecordEvent()
    {}

    public void SaveGoals()
    {}

    public void LoadGoals()
    {}
}