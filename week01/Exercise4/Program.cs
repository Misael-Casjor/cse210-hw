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
            string number = Console.ReadLine();
            int intnumber = int.Parse(number);
            numbers.Add(intnumber);
            Console.WriteLine("Enter another number");
            number = Console.ReadLine();
            intnumber = int.Parse(number);
        } while  (intnumber != 0);
    }   
        
    
        
    
}