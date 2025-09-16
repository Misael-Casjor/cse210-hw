using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        PromptGenerator prompt = new PromptGenerator();
        string _thePrompt = prompt.RandomPrompt();
        Console.WriteLine(_thePrompt);
        Journal journal = new Journal();

        int option = 1;
        do
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 write ");
            Console.WriteLine("2 display");
            Console.WriteLine("3 load");
            Console.WriteLine("4 save");
            Console.WriteLine("5 ");
            Console.WriteLine("6 quit");

            if (option == 1)
            {
                journal.AddEntry();
            }
            if (option == 2)
            {

            }
            if (option == 3)
            {

            }
            if (option == 4)
            {

            }
            if (option == 5)
            {

            }
            if (option == 6)
            {

            }
        } while (option != 6);
    }
}