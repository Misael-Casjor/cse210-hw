public class Journal
{


    List<Entry> _entries = new List<Entry>();



    public void AddEntry()
    {
        Entry entry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        string _thePrompt = prompt.RandomPrompt();
        entry._promptext = _thePrompt;
        Console.WriteLine(_thePrompt);
        entry._entryText = Console.ReadLine();
        _entries.Add(entry);
       
    }

    public void DisplayAll()
    {
        
    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }
}