using System.ComponentModel.DataAnnotations;

public class ListingActivity : Activity
{
    private int _count;
    private string[] _prompts = {
        "--- List as many things as you can that you are grateful for.",
        "--- List as many personal strengths as you can. ---",
        "--- List as many achievements you are proud of. ---",
        "--- List as many people who have positively influenced your life. ---",
        "--- List as many activities that make you happy. ---"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30)
    {
        _count = 0;
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Length);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine($"You have {_duration} seconds to list as many items as you can. Start listing now:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    userList.Add(input);
                    _count++;
                }
            }
        }

        return userList;
    }

    public void Run()
    {
        DisplayStartMessage();
        GetRandomPrompt();
        List<string> userList = GetListFromUser();
        Console.WriteLine($"\nYou listed {_count} items. Well done!");
        DisplayEndingMessage();
    }
}