using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        //gess my number game
        int magicNumber;
        int response;
        Console.WriteLine("enter the magic number");
        magicNumber = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Enter your gess");
            response = int.Parse(Console.ReadLine());
            if (response > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (response < magicNumber)
            {
                Console.WriteLine("Higer");
            }
        } while (response != magicNumber);
        Console.WriteLine("You gessed it");
    }
}