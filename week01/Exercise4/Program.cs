using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        


        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("enter a number, then enter a 0 to stop");
            string strNumber = Console.ReadLine();
            number = int.Parse(strNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        int total = 0;
        foreach(int listItem in numbers)
        {
            total += listItem;
        }

        Console.WriteLine($"the total sum is {total}");

        


        
    }     
    
        
    
}