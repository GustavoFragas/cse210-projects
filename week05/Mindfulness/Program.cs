using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Activities!");
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter the number of your choice: ");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.run();
                break;
            case "2":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.run();
                break;
            case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.run();
                break;
            default:
                Console.WriteLine("Invalid choice. Please restart the program and select a valid option.");
                break;
        }

        Console.WriteLine("Thank you for participating in the Mindfulness Activities. Have a great day!");
    }
}