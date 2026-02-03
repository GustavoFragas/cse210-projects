using System;

public class MathAssignment : Assignment
{
    private string _textBookSection = "Random";
    private string _problems = "Random";

    public MathAssignment() : base()
    {

    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}, his section is {_textBookSection} and his problems is {_problems}";
    }
}
