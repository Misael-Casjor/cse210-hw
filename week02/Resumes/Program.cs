using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2020";
        job1._endYear = "2024";

        Job job2 = new Job();

        job2._jobTitle = "Web Developer";
        job2._company = "Apple";
        job2._startYear = "2019";
        job2._endYear = "2025";


        
        Resume person1 = new Resume();

        person1._name = "Misael Castro";
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);

        person1.Display();
 


            
        
    
    }
}