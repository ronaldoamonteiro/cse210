using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void RecordEvent(int goalIndex)
    {
        Goal goal = _goals[goalIndex];
        int pointsEarned = goal.RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.\n");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
                file.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] details = parts[1].Split(",");

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3])));
            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[3]), int.Parse(details[5])));
        }
    }
}
