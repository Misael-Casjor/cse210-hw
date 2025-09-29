using System.Runtime.CompilerServices;
using System.Security;

public class Scripture
{
    Reference _reference = new Reference("predetermined", 0, 0);
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        //////////////
        /// 
        /// 
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string part in words)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int NumberToHide)
    {
        _words[NumberToHide].Hide();
    }

    public string getDisplayText()
    {
        string theLine = "";
        foreach (Word word in _words)
        {
            theLine += word.getDisplayText() + " ";
        }

        return theLine;


    }

    public bool IsCompletelyHidden()
    {
        int _count = 0;
        int _listLength = _words.Count;
        foreach (Word part in _words)
        {
            if (part.isHidden())
            {
                _count = +1;
            }


        }
        if (_count == _listLength)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}