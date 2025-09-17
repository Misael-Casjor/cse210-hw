using System.Runtime.CompilerServices;

public class Entry
{
    public DateTime _date = DateTime.Now;
    public string _promptext;
    public string _entryText;



    public void Display()
    {
        Console.WriteLine($" {_date}/ {_promptext}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }


}