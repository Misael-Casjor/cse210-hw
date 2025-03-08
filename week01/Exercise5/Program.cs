using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

 
 




        static void DisplayWelcome()
        {
            Console.WriteLine($"Wellcome!");
        }
        static string DisplayUserName(){
          Console.WriteLine("Whats your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!");
            return userName;  
        }

        static int PrompUserNumber(){
            Console.WriteLine("Tell me your favorite number");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
                 
        }

        static int SquareNumber( int number){
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int number){
            {
                Console.WriteLine($"{name}, the square of your number is {number}");
           
            }
        }


        DisplayWelcome();
        string Name = DisplayUserName();
        int Number = PrompUserNumber();
        int squared = SquareNumber(Number);
        DisplayResult(Name, squared);


    }


    
}