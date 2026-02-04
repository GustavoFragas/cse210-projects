public class ReflectingActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you overcame a significant challenge.",
        "Reflect on a moment when you felt truly at peace.",
        "Consider a situation where you helped someone in need.",
        "Recall an experience that made you feel proud of yourself.",
        "Think about a time when you learned something new about yourself."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How can you apply the lessons from this experience in the future?",
        "What emotions did you feel during this experience?",
        "How has this experience shaped who you are today?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on meaningful experiences in your life.", 60)
    {
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Length);
        Console.WriteLine(_prompts[index]);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Length);
        Console.WriteLine(_questions[index]);
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(10);
        }
    }

    public void run()
    {
        DisplayStartMessage();
        Console.WriteLine("Get ready to reflect...");
        ShowSpinner(3);

        GetRandomPrompt();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }
}