public class Journal
{


    List<Entry> _entries = new List<Entry>();



    public void AddEntry()
    {
        Entry entry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        string _thePrompt = prompt.RandomPrompt();
        entry._promptext = _thePrompt;
        entry._promptext = Console.ReadLine(); 
       
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