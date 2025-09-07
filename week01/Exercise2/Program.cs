using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Enter your grade to convert to letter grade");
        int numGrade = int.Parse(Console.ReadLine());
        string grade = "undefined";
        bool pass = false;

        string sign = "";
        int exeed = numGrade % 10;

        if (numGrade >= 90)
        {
            grade = "A";
        }


        else if (numGrade >= 80)
        {
            grade = "B";
        }
        else if (numGrade >= 70)
        {
            grade = "C";
        }
        else if (numGrade >= 60)
        {
            grade = "D";

        }
        else if (numGrade < 60)
        {
            grade = "F";
        }

        if (numGrade >= 70)
        {
            pass = true;
        }



        if (exeed >= 7)
        {
            sign = "+";
        }

        else if (exeed < 7 & exeed > 3)
        {
            sign = "";
        }
        else if (exeed <= 3)
        {
            sign = "-";
        }





 
        if (numGrade < 97 & grade != "F")
        {
            Console.WriteLine($"your Grade is {sign}{grade}");

        }
        else
        {
            Console.WriteLine($"your Grade is {grade}");
        }
        if (pass == true)
        {
            Console.WriteLine("YOU PASSED");
        }

        else
        {
            Console.WriteLine("better luck next time");
        }
    }
}