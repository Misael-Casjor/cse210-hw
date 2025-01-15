using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers one by one, type 0 to stop");


        List<int> numbers = new List<int>();

        do
        {        
         Console.Write("Enter a Number for your list");
         string numberstr = Console.ReadLine();
         int number = int.Parse(numberstr);
        

        } while (number != 0);
    }   
        
    
        
    
}