using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers one by one, type 0 to stop");


        List<int> numbers = new List<int>();
        int number = -1;
        do
        {        
         Console.Write("Enter a Number for your list");
         string numberstr = Console.ReadLine();
         number = int.Parse(numberstr);
         if (number != 0)
         {
            numbers.Add(number);
         }


        } while (number != 0);    
          Console.Write("Here is your list:");
          Console.WriteLine(numbers);

        
    }     
    
        
    
}