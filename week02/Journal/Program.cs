using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        string chosen = "0";

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
                int randompick = pick.Next(items.Count);
                string randomprompt = items[randompick];
                Console.WriteLine(randomprompt);
                string answer = Console.ReadLine();
                FilesSaver.SaveToFile(answer);
               
            }
        }


    }
}