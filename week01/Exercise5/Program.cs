using System;

class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
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
    }
}