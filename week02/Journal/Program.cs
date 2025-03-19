using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        int option;

        do
        {
            int count = 0;
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            option = int.Parse(Console.ReadLine());


            if (option == 1)
            {
                PromptGenerator singlePromt = new PromptGenerator();
                string sPrompt = singlePromt.GetRandomPrompt();
                Entry entry = new Entry();
                entry._userEntry = Console.ReadLine();
                entry._prompt =  sPrompt;
                

                count +=1;

             }
            if (option == 2) { }
            if (option == 3) { }
            if (option == 4) { }

        } while (option != 5);
    }
}