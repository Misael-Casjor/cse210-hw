using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        int option;

        do {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            option = int.Parse(Console.ReadLine());


            if (option == 1) {
                Console.WriteLine("the randompromt will be here!");
                string userEntry = Console.ReadLine();
             }
            if (option == 2) { }
            if (option == 3) { }
            if (option == 4) { }

        } while (option != 5);
    }
}