using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("1.-New entry");
        Console.WriteLine("2.-Display the journal");
        Console.WriteLine("3.-Save the journal to a file");
        Console.WriteLine("4.-Load the journal to a file");
        Console.WriteLine("5.-CLose the program");
        Console.WriteLine("Choose your option");
        string chosen = Console.ReadLine();

        while (chosen != "5")
        {
            Console.WriteLine("1.-New entry");
            Console.WriteLine("2.-Display the journal");
            Console.WriteLine("3.-Save the journal to a file");
            Console.WriteLine("4.-Load the journal to a file");
            Console.WriteLine("5.-CLose the program");
            Console.WriteLine("Choose your option");
            chosen = Console.ReadLine();

            if (chosen == "1")
            {
                Prompts promptaccess = new Prompts(); 
                List<string> items = promptaccess._prompt;
                Random pick = new Random();
                int randompick = pick.Next(_prompt.5);
                string randomprompt = _prompt[randompick];
                Console.WriteLine(randomprompt);

            
            }
        }

    }
}