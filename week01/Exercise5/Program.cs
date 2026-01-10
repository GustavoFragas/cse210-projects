using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
        }

        DisplayMessage("Welcome to the program!");
        string username = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(username, squaredNumber);

    }
}