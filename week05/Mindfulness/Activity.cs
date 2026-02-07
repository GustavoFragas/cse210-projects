using System;
using System.Threading;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write ("How long, in seconds, would you like for this session?\n> ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Starting {_name} for {_duration} seconds.");
        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed {_name} for {_duration} seconds.");
        Console.WriteLine("Press Enter to return to the main menu.");
        Console.ReadLine();
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}