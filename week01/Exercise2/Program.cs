using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        int pGrade;
        string grade;

        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        pGrade = int.Parse(Console.ReadLine());

        if (pGrade >= 90)
        {
            grade = "A";
        }

        if (pGrade >= 80)
        {
            grade = "B";
        }

        if (pGrade >= 70)
        {
            grade = "C";
        }

        if (pGrade >= 60)
        {
            grade = "D";
        }

        if (pGrade > 50)
        {
            grade = "F";
        }
        
        
    }
}