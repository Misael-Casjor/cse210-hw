using System;
using System.Globalization;

class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromtUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(name, square);
        void  DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromtUserName()
        {
            Console.WriteLine("Enter user name:");
            string userName = Console.ReadLine();
            return  userName;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("enter you favorite number");
            string userNumber = Console.ReadLine();
            int number =  int.Parse(userNumber);
            return number;
        }
        static int SquareNumber(int number) 
        {
     
            int numberSquared = number * number;
            return numberSquared;
        }
        static void DisplayResult(string name, int square)
        {

            Console.WriteLine($"your name is {name} and squared number is {square}");
        }

    }
}