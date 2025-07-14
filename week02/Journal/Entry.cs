using System.Net.Mail;

public class Entry
{
    string _date;
    string _promptText;
    string _entryText;

    public Entry()
    {
        _date = DateTime.Now.ToString("M/d/yyyy");
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{_date}| {_promptText}: {_entryText}");
    }
 
    
}