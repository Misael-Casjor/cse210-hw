public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string getDisplayText()
    {
    if (isHidden())
            {
            string hidden = new string('_', _text.Length);
            return hidden;
            }
            else
            {
                string showntext = getDisplayText();
                return showntext;
            }
       
    }
}
