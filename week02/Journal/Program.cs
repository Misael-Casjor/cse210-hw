using System;
using System.Runtime.InteropServices;

class Program
{    //EXTRA, there is an anty dupping sistem for entries, when a file its loaded, and then
    // the save option its selected, it will ask the user if he want to re-save the loaded entries
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        PromptGenerator prompt = new PromptGenerator();
        string _thePrompt = prompt.RandomPrompt();
        Console.WriteLine(_thePrompt);
        Journal journal = new Journal();

        int option = 0;
        do
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 write ");
            Console.WriteLine("2 display");
            Console.WriteLine("3 load");
            Console.WriteLine("4 save");
            Console.WriteLine("5 quit");


            option = int.Parse(Console.ReadLine());
            
            if (option == 1)
            {
                journal.AddEntry();
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                journal.LoadFromFile();
            }
            else if (option == 4)
            {
                journal.SaveToFile();
            }

        } while (option != 5);
    }
}