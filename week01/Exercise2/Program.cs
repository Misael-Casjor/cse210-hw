using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        int pGrade;
        string grade;
        bool pass = false;

        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        pGrade = int.Parse(Console.ReadLine());

        if (pGrade >= 90)
        {
            grade = "A";
        }

        else if (pGrade >= 80)
        {
            grade = "B";
        }

        else if (pGrade >= 70)
        {
            grade = "C";
        }

        else if (pGrade >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }

        if (pGrade >= 70)
        {
            pass = true;
        }


        if (pass = true)
        {
            Console.WriteLine($"You passed! Your grade is {grade}");
        }
        else
        {
            Console.WriteLine($"keep going! you dint pass, your grade is {grade}");
        }
    }
}