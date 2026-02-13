using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                manager.CreateGoal();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                manager.Start();
            }
            else if (choice == "2")
            {
                Console.Clear();
                manager.DisplayPlayerInfo();
                manager.ListGoalDetails();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                manager.Start();
            }
            else if (choice == "3")
            {
                Console.Clear();
                manager.SaveGoals();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                manager.Start();
            }
            else if (choice == "4")
            {
                Console.Clear();
                manager.LoadGoals();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                manager.Start();
            }
            else if (choice == "5")
            {
                Console.Clear();
                manager.RecordEvent();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                manager.Start();
            }
            else if (choice == "6")
            {
                Console.Clear();
                Console.WriteLine("\n======================================");
                Console.WriteLine("   Thanks for playing Eternal Quest!");
                Console.WriteLine("======================================");
                Console.WriteLine($"Final Score: {manager.GetScore()} points");
                Console.WriteLine("Keep pushing yourself! Goodbye!\n");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}