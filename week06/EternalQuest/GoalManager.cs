using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    private int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    private string GetRank()
    {
        int level = GetLevel();
        if (level == 1) return "Beginner";
        else if (level == 2) return "Apprentice";
        else if (level == 3) return "Warrior";
        else if (level == 4) return "Champion";
        else if (level >= 5) return "Legend";
        return "Beginner";
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("   Welcome to the Eternal Quest!");
        Console.WriteLine("======================================");
        Console.WriteLine($"Your current score: {_score} points");
        Console.WriteLine($"Your level: {GetLevel()} ({GetRank()})");
        Console.WriteLine();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Level: {GetLevel()} - Rank: {GetRank()}");
        int pointsToNextLevel = 1000 - (_score % 1000);
        Console.WriteLine($"Points to next level: {pointsToNextLevel}\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int goalNumber = 0; goalNumber < _goals.Count; goalNumber++)
        {
            Console.WriteLine($"{goalNumber + 1}. {_goals[goalNumber].Name}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        for (int goalNumber = 0; goalNumber < _goals.Count; goalNumber++)
        {
            Console.WriteLine($"{goalNumber + 1}. {_goals[goalNumber].GetDetailsString()}");
        }
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
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int selectedGoalIndex = int.Parse(Console.ReadLine()) - 1;

        if (selectedGoalIndex >= 0 && selectedGoalIndex < _goals.Count)
        {
            Goal goal = _goals[selectedGoalIndex];
            
            if (goal is SimpleGoal && goal.IsComplete())
            {
                Console.WriteLine("\nYou already achieved this goal!");
                Console.WriteLine("Try another goal or create a new one to keep earning points.\n");
                return;
            }
            
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                Console.WriteLine("\n You already completed this checklist goal!");
                Console.WriteLine("Try another goal or create a new one to keep earning points.\n");
                return;
            }
            
            int previousLevel = GetLevel();
            goal.RecordEvent();
            _score += goal.Points;

            Console.WriteLine($"\n Congratulations! You have earned {goal.Points} points!");

            if (goal is ChecklistGoal cGoal && cGoal.IsComplete())
            {
                int bonus = cGoal.GetBonus();
                _score += bonus;
                Console.WriteLine($"BONUS! You have earned {bonus} additional points for completing the checklist!");
            }

            Console.WriteLine($"You now have {_score} points.");
            
            int newLevel = GetLevel();
            if (newLevel > previousLevel)
            {
                Console.WriteLine($"\nLEVEL UP! You are now level {newLevel} - {GetRank()}! 🌟\n");
            }
        }
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
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int lineNumber = 1; lineNumber < lines.Length; lineNumber++)
            {
                string[] parts = lines[lineNumber].Split(':');
                string goalType = parts[0];
                string[] data = parts[1].Split(',');

                if (goalType == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (bool.Parse(data[3]))
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                }
                else if (goalType == "ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]));
                    for (int completionCount = 0; completionCount < int.Parse(data[5]); completionCount++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}