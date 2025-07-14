public class Entry
{
    string _date;
    string _promptText;
    string _entryText;

    public Entry()
    {

    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{_date}| {_promptText}: {_entryText}");
    }
 
    
}