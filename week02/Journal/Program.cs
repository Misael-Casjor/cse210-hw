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
        string chosen = "0";
        string answer = "";
        string filecontent = "";

        while (chosen != "5")
  
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
            chosen = Console.ReadLine();

            if (chosen == "1")
            {
   


                Console.WriteLine(randomprompt);
                answer = Console.ReadLine();
                Console.WriteLine("SELECT OPTION 3 TO SAVE JOUR JOURNAL");
                
               
            }
            else if (chosen == "2")
            {
              if (answer == "" && filecontent == "" )  
              {
                Console.WriteLine("No file loaded or prompt written, do one or both to display them here");  
              }
              else if (answer == "" && filecontent != "")
              {
                Console.WriteLine(filecontent);
              }
              else
              {
                  Console.WriteLine("Press option 3 to se your entire Journal");
                  Console.WriteLine($"recent prompt: {randomprompt} {answer}");
                  if (filecontent == "")
                    {
                        Console.WriteLine("No Journal loaded 3, go to option 3 to see your entire yournal");
                    }
                    else
                    {
                       Console.WriteLine(filecontent);
                    }
              }
              

            }
            else if (chosen == "3")
            {
            FilesSaver.SaveToFile($"{randomprompt} {answer}");
            Console.WriteLine("YOUR ENTRY HAS BEEN ADDED SUCCESFULLY");   
            }
            else if (chosen == "4")
            {
 
             
              filecontent = Loader.ReadFromFile();
              Console.WriteLine("Journal loaded");
            }
            else if (chosen == "5")
            {
                break; 
            }
        }


    }
}