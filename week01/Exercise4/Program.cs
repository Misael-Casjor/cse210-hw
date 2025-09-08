using System;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numberList = new List<int>();
        int number = 0;
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numberList.Add(number);
                Console.WriteLine($"{number} had been added to the list succesfully!");
            }


        } while (number != 0);
        Console.WriteLine("exiting the loop mode");

        int smaller = 999999999;
        int bigger = -99999999;
        int sum = 0;
        for (int i = 0; i < numberList.Count; i++)
        {

            int fromList = numberList[i];
            Console.WriteLine(fromList);
            if (smaller > fromList & fromList > 0)
            {
                smaller = fromList;
            }
            if (bigger < fromList)
            {
                bigger = fromList;
            }
            sum += fromList;

        }


        double average = (double)sum / numberList.Count;
        Console.WriteLine($"the smallest positive number is {smaller}");
        Console.WriteLine($"the bigest number is {bigger}");
        Console.WriteLine($"the sum of the numbers is {sum}");
        Console.WriteLine($"this is the average {average}");
        Console.WriteLine($"here is the sorted List");
        numberList.Reverse();
        for (int i = 0; i < numberList.Count; i++)
        {

            int fromList = numberList[i];
            Console.WriteLine(fromList);


        }
    }
}