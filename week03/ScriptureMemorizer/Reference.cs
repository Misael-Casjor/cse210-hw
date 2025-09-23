public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endverse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startverse;
        _endverse = endverse;
    }


    public string getDisplayText()
    {
        return $"{_book} {_chapter} {_verse} {_endverse}";
    }

}