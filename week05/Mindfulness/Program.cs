using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Activities!");
        bool exit = false;

        while (!exit)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Enter the number of your choice: ");
        string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    Console.Clear();
                    break;
                    
                    
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    Console.Clear();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    exit = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }
        }

        Console.WriteLine("Thank you for participating in the Mindfulness Activities. Have a great day!");
    }
}