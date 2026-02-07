public class ReflectingActivity : Activity
{
    private string[] _prompts = {
        "--- Think of a time when you overcame a significant challenge. ---",
        "--- Reflect on a moment when you felt truly at peace. ---",
        "--- Consider a situation where you helped someone in need. ---",
        "--- Recall an experience that made you feel proud of yourself. ---",
        "--- Think about a time when you learned something new about yourself. ---"
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How can you apply the lessons from this experience in the future?",
        "What emotions did you feel during this experience?",
        "How has this experience shaped who you are today?"
    };
    private Random _rand = new Random();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30)
    {
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Length);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(_prompts[index]);
        Console.WriteLine();
        return _prompts[index];
    }

    public void DisplayQuestions()
    {
        int index = _rand.Next(_questions.Length);
        Console.Write(_questions[index]);
        Console.Write(" Waiting: ");
        ShowSpinner(10);
        Console.WriteLine();
    }

    public void Run()
    {
        DisplayStartMessage();
        GetRandomPrompt();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }

        DisplayEndingMessage();
    }
}