public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breath.", 30)
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);

            Console.WriteLine("\nBreathe out...");
            ShowCountdown(6);
        }

        DisplayEndingMessage();
    }
}