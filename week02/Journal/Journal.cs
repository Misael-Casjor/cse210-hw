using System;
public class Journal{

    int option;
    List<Entry> _entries = new List<Entry>();
    List<string> loadedFile = new List<string>();
    int count = 0;
    string fileName = "entries.txt";

    public void EnterEntry(){
        Entry entry = new Entry();
        PromptGenerator singlePromt = new PromptGenerator();
        string sPrompt = singlePromt.GetRandomPrompt();
        Console.WriteLine($"{entry._date}|{sPrompt}");
        entry._prompt = sPrompt;
        entry._userEntry = Console.ReadLine();
        _entries.Add(entry);


        count += 1;
    }
   
    public void DisplayEntries(){
        foreach (Entry item in _entries)
        {
            Console.WriteLine(item.EntireEntry());
        }
        foreach (string loaded in loadedFile)
        {
            Console.WriteLine(loaded);
        }
        Console.WriteLine("Press enter to go back to menu");
        Console.ReadLine();

    }

    public void LoadEntries(){
        loadedFile.Clear();//I added this so the list gets overwrited instead of duplicated when you try to 
                           //load the file twice 
        string[] lines = System.IO.File.ReadAllLines(fileName);// from the assigment page

        foreach (string line in lines)
        {
            loadedFile.Add(line);
        }
        Console.WriteLine($"the file ({fileName}) has been loaded succesfully");
    }
    public void SaveEntries(){

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine(item.EntireEntry());
            }
        Console.WriteLine("the entries have been saved SUCCESSFULLY!");
        _entries.Clear();
        count = 0;

    }
    public void ShowSaveWarning(){
        if (count == 1)
        {
            Console.WriteLine($"ATTENTION you have {count} entry widout saving, remember to save your entry");
        }
        if (count > 1)
        {
            Console.WriteLine($"ATTENTION you have {count} entries widout saving, remember to save your entries");
        }
    }
}