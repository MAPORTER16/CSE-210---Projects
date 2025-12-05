using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber > 0 && goalNumber <= _goals.Count)
        {
            Goal goal = _goals[goalNumber - 1];
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;

            if (pointsEarned > 0)
            {
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] details = parts[1].Split('|');

                if (goalType == "SimpleGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);
                    bool isComplete = bool.Parse(details[3]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                }
                else if (goalType == "EternalGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);
                    int targetCount = int.Parse(details[3]);
                    int bonusPoints = int.Parse(details[4]);
                    int timesCompleted = int.Parse(details[5]);
                    _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints, timesCompleted));
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
