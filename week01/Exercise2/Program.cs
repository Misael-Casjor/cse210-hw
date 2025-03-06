using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        int userPersentage = 0;
        string grade = "";
        Console.WriteLine("Enter your percentage");
        userPersentage = int.Parse(Console.ReadLine());

        if (userPersentage >= 90){
            grade = "A";
        }
        else if (userPersentage >= 80)
        {
            grade = "B";
        }
        else if (userPersentage >= 70)
        {
            grade = "C";
        }
        else if (userPersentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");


    }
}