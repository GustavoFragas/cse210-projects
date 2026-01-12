using System;
public class Job
{
    public string _company;
    public string _jobtitle;
    public string _startYear;
    public string _endYear;

    public void displayJob()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startYear} - {_endYear}");
    }
}