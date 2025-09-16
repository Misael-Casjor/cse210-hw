using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public string _promptext;
    public string _entryText;

    public void Diplay()
    {
        Console.WriteLine($" {_date} {_promptext} {_entryText}");
    }


}