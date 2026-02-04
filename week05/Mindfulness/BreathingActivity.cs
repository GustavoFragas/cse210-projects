public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.", 60)
    {
    }

    public void run()
    {
        DisplayStartMessage();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        Console.WriteLine("\nBreathe in...");
        ShowCountdown(4);

        Console.WriteLine("\nBreathe out...");
        ShowCountdown(6);

        DisplayEndingMessage();
    }
}