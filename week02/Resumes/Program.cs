using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        Job _job1 = new Job();
        myResume._name = "Misael";
        myResume._jobs.Add(_job1);
        myResume._jobs[0]._company = "Microsoft";
        myResume._jobs[0]._jobTitle = "Software Engeneer";
        myResume._jobs[0]._startYear = 2020;
        myResume._jobs[0]._endYear = 2022;

        Job _job2 = new Job();
        myResume._jobs.Add(_job2);
        myResume._jobs[1]._company = "Apple";
        myResume._jobs[1]._jobTitle = "Manager";
        myResume._jobs[1]._startYear = 2022;
        myResume._jobs[1]._endYear = 2024;


        myResume.DisplayJobList();
    }
}