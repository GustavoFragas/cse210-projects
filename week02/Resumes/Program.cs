using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobtitle = "Software Engineer";
        Job1._startYear = "2015";
        Job1._endYear = "2020";

        Job Job2 = new Job();
        Job2._company = "Google";
        Job2._jobtitle = "Senior Developer";
        Job2._startYear = "2020";
        Job2._endYear = "Present";

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);
        myResume.displayResume();

        
    }
}