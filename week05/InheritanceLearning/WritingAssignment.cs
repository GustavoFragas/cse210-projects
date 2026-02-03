using System;

public class WritingAssignment : Assignment
{
    private string _title = "Random";

    public WritingAssignment() : base()
    {

    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}, and the title is {_title}";
    }
}
