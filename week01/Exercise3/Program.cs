using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int? userGuess = 0;


        // Console.WriteLine("What is the magic number?");
        // string inputMagic = Console.ReadLine();

        // int magicNumber = int.Parse(inputMagic);
        int? guess = null;

        while (guess != magicNumber)
        {
            userGuess += 1;
            Console.WriteLine("What is your guess?");
            string inputGuess = Console.ReadLine();
            guess = int.Parse(inputGuess);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {userGuess} guesses to find the magic number {magicNumber}.");
                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "yes")
                {
                    Console.Clear();
                    magicNumber = randomGenerator.Next(1, 101);
                    guess = null;
                    userGuess = 0;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }

        }
    }
}