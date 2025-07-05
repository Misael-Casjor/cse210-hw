using System;
using System.ComponentModel.Design;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers;
        numbers = new List<int>();
        int toAdd;
        int sum = 0;
        int count = 0;
        int largest = 0;
        int smallest = int.MaxValue;//looked online for this technice in specific(only this line)
        Console.WriteLine("Enter a list of numbers, type 0 when youre done");
        do
        {
            Console.WriteLine("Enter the number you want to add(type 0 to finish):");
            toAdd = int.Parse(Console.ReadLine());
            if (toAdd != 0)
            {
                numbers.Add(toAdd);
            }
        } while (toAdd != 0);

        Console.WriteLine("this is your list");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
            sum += item;
            count += 1;
            if (item > largest)
            {
                largest = item;
            }
            if (item > 0 && item < smallest)
            {
                smallest = item;
            }
        }

        int average = sum / count;
        Console.WriteLine($"the sum is {sum}");
        Console.WriteLine($"the average is {average}");
        Console.WriteLine($"the largest is {largest}");
        Console.WriteLine($"The smallest positive is {smallest}");

    }
}