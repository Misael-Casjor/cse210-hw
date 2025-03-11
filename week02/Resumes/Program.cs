using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Microsoft";
        job2._company = "Apple";

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
}