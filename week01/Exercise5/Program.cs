using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);
        DisplayResult(name, square);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            return name;

        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter a number");
            int usernumber = int.Parse(Console.ReadLine());
            return usernumber;
        }

        static int SquareNumber(int usernumber)
        {
            int square = usernumber * usernumber;
            return square;
        }

        static void DisplayResult(string name, int square) {
            Console.WriteLine($"Brother {name}, the square of your number is {square}");
        }
    }
}