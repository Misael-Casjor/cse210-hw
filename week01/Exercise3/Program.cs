using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int answer = 0;
        int tries = 0;
        do
        {
             Console.WriteLine("Gess the number");
             answer = int.Parse(Console.ReadLine());
             tries += 1;
             if (answer > number){
                Console.WriteLine("Smaller");
             }
             else{
                Console.WriteLine("Bigger");
             }


        } while (answer != number);
        Console.WriteLine($"you gessed the number, it was {number}. Number of tries: {tries}!");
    }
}