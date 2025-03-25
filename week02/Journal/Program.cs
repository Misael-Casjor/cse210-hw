using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// extra, this program will count how many entries you have writted without beeing saved and it will
// send a warning example: you writed 3 entries, please SAVE them before closing the program

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        int option;
        List<Entry> _entries = new List<Entry>();
        List<string> loadedFile = new List<string>();
        int count = 0;
        string fileName = "entries.txt";
        do
        {
            
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            option = int.Parse(Console.ReadLine());
            if (count > 0){
                if(count == 1){
                    Console.WriteLine($"ATTENTION you have {count} entry widout saving, remember to save your entry");
                }
                if(count > 1){
                    Console.WriteLine($"ATTENTION you have {count} entries widout saving, remember to save your entries");
                }
            
            }


            if (option == 1)
            {
                Entry entry = new Entry();
                PromptGenerator singlePromt = new PromptGenerator();
                string sPrompt = singlePromt.GetRandomPrompt(); 
                Console.WriteLine($"{entry._date}|{sPrompt}");
                entry._prompt = sPrompt;
                entry._userEntry = Console.ReadLine();
                _entries.Add(entry);


                count +=1;

             }
            if (option == 2) {
                foreach (Entry item in _entries){
                    Console.WriteLine(item.EntireEntry());
                }
                
             }
            if (option == 3) {
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    loadedFile.Add(line);
                }

            }
            if (option == 4) {
                
                using (StreamWriter outputFile = new StreamWriter(fileName))
                    foreach (Entry item in _entries)
                    {
                        outputFile.WriteLine(item.EntireEntry());
                    }
                count = 0;
             }

        } while (option != 5);
    }
}