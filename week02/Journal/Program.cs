using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
// EXTRAS if you have no loaded your journal or not Written a prompt, i will display a messaje
// indicating you that at option 2
class Program
{
    static void Main(string[] args)
    {
        string _chosen = "0";
        string _answer = "";
        string _filecontent = "";

        while (_chosen != "5")
  
        {                
            Prompts promptaccess = new Prompts(); 
            List<string> items = promptaccess._prompt;
            Random pick = new Random();
            int randompick = pick.Next(items.Count);
            string randomprompt = items[randompick];
    
            Console.WriteLine("1.-New entry");
            Console.WriteLine("2.-Display the journal");
            Console.WriteLine("3.-Save the journal to a file");
            Console.WriteLine("4.-Load the journal from a file");
            Console.WriteLine("5.-Close the program");
            Console.WriteLine("Choose your option");
            _chosen = Console.ReadLine();

            if (_chosen == "1")
            {
   


                Console.WriteLine(randomprompt);
                _answer = Console.ReadLine();
                Console.WriteLine("SELECT OPTION 3 TO SAVE JOUR JOURNAL");
                
               
            }
            else if (_chosen == "2")
            {
              if (_answer == "" && _filecontent == "" )  
              {
                Console.WriteLine("No file loaded or prompt written, do one or both to display them here");  
              }
              else if (_answer == "" && _filecontent != "")
              {
                Console.WriteLine(_filecontent);
              }
              else
              {
                  Console.WriteLine("Press option 3 to se your entire Journal");
                  Console.WriteLine($"recent prompt: {randomprompt} {_answer}");
                  if (_filecontent == "")
                    {
                        Console.WriteLine("No Journal loaded 3, go to option 3 to see your entire yournal");
                    }
                    else
                    {
                       Console.WriteLine(_filecontent);
                    }
              }
              

            }
            else if (_chosen == "3")
            {
            FilesSaver.SaveToFile($"{randomprompt} {_answer}");
            Console.WriteLine("YOUR ENTRY HAS BEEN ADDED SUCCESFULLY");   
            }
            else if (_chosen == "4")
            {
 
             
              _filecontent = Loader.ReadFromFile();
              Console.WriteLine("Journal loaded");
            }
            else if (_chosen == "5")
            {
                break; 
            }
        }


    }
}