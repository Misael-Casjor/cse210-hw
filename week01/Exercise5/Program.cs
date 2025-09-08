using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromtpUserName()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            return name;
        }

        static void displayName(string name)
        {
            Console.WriteLine($"Your name is {name}");
        }

        static int displayUserNumber()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square} ");
        }
        DisplayWelcome();
        string name = PromtpUserName();
        displayName(name);
        int number = displayUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
}