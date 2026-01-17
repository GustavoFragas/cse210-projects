using System;

public class Validator
{
    public int numberValidator(int choice)
    {
        while (true)
            if (choice >= 1 && choice <= 5)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid Number. Enter a number 1-5");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsedChoice)) // Try to convert string to int
                {
                    if (parsedChoice >= 1 && parsedChoice <= 5)
                    {
                        return parsedChoice; // Valid input, return it
                    }
                    // If parsed, but out of range, the loop continues to ask again
                }
            }


    }
}
