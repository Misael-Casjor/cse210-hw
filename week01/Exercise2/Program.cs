using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Enter the your percentage grade:");
        string percentage = Console.ReadLine();
        int forCalculation = int.Parse(percentage);

        string letter = "x";

        string congratEncourage = "";
 
        if (forCalculation < 60)
        {
           letter = "F";
        }
        else if (forCalculation >= 60)
        {
            letter = "D";
        }
        else if (forCalculation >= 70)
        {
            letter = "C";

        }
        else if (forCalculation >= 80)
        {
            letter = "B";

        }
        else if (forCalculation >= 90)
        {
            letter = "A";

        }
        if (forCalculation >= 70)
        {
            congratEncourage = ", Congrats You passed!";
        }
        else if (forCalculation < 70)
        {
            congratEncourage = ", dint pass this time, remember to keep going you can do it!";
        }
        
        Console.WriteLine($"Your grade Is {letter}{congratEncourage}");
    }
}