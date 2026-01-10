using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);

        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
            if (grade < 93)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            if (grade >= 87)
            {
                letterGrade += "+";
            }
            else if (grade < 83)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            if (grade >= 77)
            {
                letterGrade += "+";
            }
            else if (grade < 73)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            if (grade >= 67)
            {
                letterGrade += "+";
            }
            else if (grade < 63)
            {
                letterGrade += "-";
            }
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course.");
        }




        // if (grade >= 90)
        // {
        //     Console.WriteLine("Your letter grade is A.");
        // }
        // else if (grade >= 80)
        // {
        //     Console.WriteLine("Your letter grade is B.");
        // }
        // else if (grade >= 70)
        // {
        //     Console.WriteLine("Your letter grade is C.");
        // }
        // else if (grade >= 60)
        // {
        //     Console.WriteLine("Your letter grade is D.");
        // }
        // else
        // {
        //     Console.WriteLine("Your letter grade is F.");
        // }

        // if (grade >= 70)
        // {
        //     Console.WriteLine("Congratulations! You passed the course.");
        // }
        // else
        // {
        //     Console.WriteLine("Unfortunately, you did not pass the course.");
        // }
    }
}