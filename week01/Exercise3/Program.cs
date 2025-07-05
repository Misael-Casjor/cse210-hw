using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        //gess my number game
        int magicNumber;
        int response;
        string proceed;
        int tries = 0;
        do
        {
            Random magicNumberGenerator = new Random();
            magicNumber = magicNumberGenerator.Next(1, 101);

            do
            {
                tries += 1;
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
            Console.WriteLine("You gessed it!");
            Console.WriteLine($"it took you {tries} tries!");
            Console.WriteLine("want to play again? (type 'yes' to continue)");
            proceed = Console.ReadLine();

        } while (proceed == "yes");
    }
}