using System.Linq.Expressions;
using System;

public class Assignment
{
    protected string _studentName = "Random";
    protected string _topic = "Random";

    public Assignment()
    {

    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"The topic is {_topic} and the name of the student is {_studentName}";
    }


}
