using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a lis of numbers, type 0 to stop");
        string number = Console.ReadLine();
        int intnumber = int.Parse(number);

        List<int> numbers = new List<int>();

        while  (intnumber != 0)
        {
            numbers.Add(intnumber);   
        }
    }  
        
    
        
    
}