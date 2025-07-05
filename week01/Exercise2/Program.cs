using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        int pGrade;
        string grade;
        string totalGrade;
        int plusOrMines;


        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        pGrade = int.Parse(Console.ReadLine());
        plusOrMines = pGrade % 10;
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



        if (plusOrMines >= 7 && grade != "A" && grade != "F")
        {
            totalGrade = $"+{grade}";
        }
        else if (plusOrMines < 3 && grade != "F")
        {
            totalGrade = $"-{grade}";
        }
        else
        {
            totalGrade = grade;
        }

        Console.WriteLine($"Your grade is {totalGrade}");
        


        
        
    }
}