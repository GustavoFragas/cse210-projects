using System;
using System.Data;

public class Difficulty
{

    public string DifficultyLevel(string input)
    {
        switch (input.ToLower())
        {
            case "easy":
                return "easy";
            case "medium":
                return "medium";
            case "hard":
                return "hard";
            default:
                throw new ArgumentException("Invalid difficulty level. Please choose 'easy', 'medium', or 'hard'.");
        }
    }

}
