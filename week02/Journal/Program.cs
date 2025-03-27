using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// Extra, this program will count how many entries you have writted without beeing saved and it will
// send a warning example: you writed 3 entries, please SAVE them before closing the program

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        int option;
 

        Journal journal = new Journal();

        do
        {
            
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            option = int.Parse(Console.ReadLine());

            
            

            if (option == 1)
            {
             journal.EnterEntry();
            }

            else if (option == 2) {
              journal.DisplayEntries();
             }

            else if (option == 3) {
               journal.LoadEntries();

            }
            else if (option == 4) {
                journal.SaveEntries();

             }




            else {
                Console.WriteLine("please enter a number between 1 and 5");
            }

        } while (option != 5);
    }
}