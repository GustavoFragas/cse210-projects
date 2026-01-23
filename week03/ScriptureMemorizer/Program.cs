using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Scripture Memorizer!");

        Difficulty dif = new Difficulty();
        string level = "";

        while (true)
        {
            Console.WriteLine("What will be the difficulty level? (easy, medium, hard)");
            string difficulty = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(difficulty))
            {
                Console.WriteLine("Please enter a difficulty level.");
                Console.WriteLine();
                continue;
            }

            try
            {
                level = dif.DifficultyLevel(difficulty.ToLower());
                Console.Clear();
                break;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }

        Scripture scripture = null;

        if (level == "easy")
        {
            Reference reference = new Reference("John", 3, 16);
            string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            scripture = new Scripture(reference, scriptureText);
        }
        else if (level == "medium")
        {

            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            scripture = new Scripture(reference, scriptureText);

        }
        else if (level == "hard")
        {
            Reference reference = new Reference("1 Nephi", 2, 6, 8);
            string scriptureText = "Wherefore, redemption cometh in and through the Holy Messiah; for he is full of grace and truth. Behold, he offereth himself a sacrifice for sin, to answer the ends of the law, unto all those who have a broken heart and a contrite spirit; and unto none else can the ends of the law be answered. Wherefore, how great the importance to make these things known unto the inhabitants of the earth, that they may know that there is no flesh that can dwell in the presence of God, save it be through the merits, and mercy, and grace of the Holy Messiah, who layeth down his life according to the flesh, and taketh it again by the power of the Spirit, that he may bring to pass the resurrection of the dead, being the first that should rise.";
            scripture = new Scripture(reference, scriptureText);
        }

        if (scripture == null)
        {
            Console.WriteLine("Failed to initialize scripture. Exiting program.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
