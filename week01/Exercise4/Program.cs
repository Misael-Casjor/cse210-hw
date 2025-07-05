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
        Console.WriteLine("Enter a list of numbers, type 0 when youre done");
        do
        {
            Console.WriteLine("Enter the number you want to add:");
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
        }

    }
}