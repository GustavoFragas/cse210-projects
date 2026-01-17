public class PromptGenerator
{
    public List<string> _entries = new List<string>();

    public PromptGenerator()
    {
        _entries.Add("What was the best part of your day?");
        _entries.Add("What are you grateful for today?");
        _entries.Add("Describe a challenge you faced today.");
        _entries.Add("What did you learn today?");
        _entries.Add("Write about a memorable moment from today.");
    }

    public string getRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_entries.Count);
        return _entries[index];
    }
}
