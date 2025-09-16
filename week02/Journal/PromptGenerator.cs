public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    Random _randomP = new Random();

   
    public PromptGenerator()
    {

        _prompts.Add("Something that are you gratefull about");
        _prompts.Add("If you can change something from today, what it could be?");
        _prompts.Add("Any new goal that do you want to achieve");
        _prompts.Add("What would you like to do better tomorrow?");
        _prompts.Add("What maked you smile today?");
        

    }



    public string RandomPrompt()
    {
        int _index = _randomP.Next(_prompts.Count);
        string _thePrompt = _prompts[_index];
        return _thePrompt;
    }


}