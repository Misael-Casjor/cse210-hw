using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random magicNumber = new Random();
     
        int gess = 0;
        
        string playAgain = "yes";
        Console.WriteLine("Gess a number from 1 to 100");
        do
        {
            int number = magicNumber.Next(1, 101);
            int count = 0;

            while (number != gess)
            {
                Console.WriteLine("make a gess");
                gess = int.Parse(Console.ReadLine());
                count += 1;

                if (gess > number)
                {
                    Console.WriteLine("Smaller");
                }
                else if (gess < number)
                {
                    Console.WriteLine("Bigger");
                }
                if (number == gess)
                {
                    Console.WriteLine($"You guessed the number! it was {number}, you gessed {count} times");
                    Console.WriteLine("Wanna play again?(type 'yes' to continue)");
                    playAgain = Console.ReadLine();
                }
            }
            
        } while (playAgain == "yes");

        Console.WriteLine("See you later!");


    }
}