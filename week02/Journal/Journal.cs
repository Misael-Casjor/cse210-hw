using System.Runtime.CompilerServices;

public class Journal
{


    List<Entry> _entries = new List<Entry>();
    List<string> _loads = new List<string>();//this is to prevent to duplicate loaded entries when you save
    string _filename = "";
    bool _loadedfile = false;
    string _continue = "";



    public void AddEntry()
    {
        Entry entry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        string _thePrompt = prompt.RandomPrompt();
        entry._promptext = _thePrompt;
        Console.WriteLine(entry._date);
        Console.WriteLine(_thePrompt);
        entry._entryText = Console.ReadLine();
        _entries.Add(entry);

    }

    public void DisplayAll()
    {
        if (_loadedfile == true)
        {
            foreach (string lines in _loads)
            {
                Console.WriteLine(lines);
            }
        }
        
        foreach (Entry record in _entries)
        {
            record.Display();
            
            
        }
        Console.WriteLine("enter anything to continue");//this is so the menu doesnt pop up over the entries
        Console.ReadLine();
    }

    public void SaveToFile()
    {

        Console.WriteLine("Whats the name of the file you want to save on?(just .txt files)");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry record in _entries)
            {
                outputFile.WriteLine($"{record._date} {record._promptext}: {record._entryText}  ;");
            }
            if (_loadedfile == true)
            {
                string answer = "";
                Console.WriteLine("you loaded entries from a file before, would you like to save them again?");
                Console.WriteLine("WARNING: this may duplicate your old entries");
                answer = Console.ReadLine();
                Console.WriteLine("Saved succesfully");
                if (answer == "No" ^ answer == "no")
                {
                    _loads.Clear();      //clears the load list without saving it
                }
                else if (answer == "Yes" ^ answer == "yes")
                {
                    foreach (string entry in _loads)
                    {
                        outputFile.WriteLine(entry);
                    }

                    _loads.Clear();
                }
                else
                {
                    Console.WriteLine("type yes or no, try again");
                }
                

            }
        }
    }

    string[] lines = System.IO.File.ReadAllLines("Entries.txt");
    public void LoadFromFile()
    {




        if (_loadedfile == true)
        {
            Console.WriteLine("you already loaded a file, this new load will overwrite your last load");
            Console.WriteLine("this will not modify the file, just visibility");
            Console.WriteLine("Continue?");
            _continue = Console.ReadLine();
            if (_continue == "Yes" ^ _continue == "yes")
            {
                _loads.Clear();// clears the list to overwrite with the new one
                Console.WriteLine("What file whould you like to load? (.txt files only)");
                _filename = Console.ReadLine();
                foreach (string line in lines)
                {
                    string[] parts = line.Split("/");
                    _loads.Add(line);

                }

            }
            else if (_continue == "No" ^ _continue == "no")
            {
                //goes back to the menu
            }
            else
            {
                Console.WriteLine("type yes or no, try again");
            }




        }
        else
        {

            Console.WriteLine("What file whould you like to load? (.txt files only)");
            _filename = Console.ReadLine();
            foreach (string line in lines)
            {
                string[] parts = line.Split(";");
                _loads.Add(line);


            }


        }
        _loadedfile = true;
        Console.WriteLine($"The file {_filename} its been loaded succesfully");
    }
}