using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        int cuantity = 0;
        int av;
        int largest = 0;
        do{
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
                numbers.Add(number);
            }


        } while (number != 0);
        foreach (int digit in numbers){ //calculations loop
        sum += digit;
        cuantity += 1;
        if (largest < digit){
            largest = digit;
            }
        }
        av = sum / cuantity;
        Console.WriteLine($"the largest number is {largest}");
        Console.WriteLine($"the sum of the numbers is {sum}");
        Console.WriteLine($"The average of the entered numbers is {av}");
    }
}