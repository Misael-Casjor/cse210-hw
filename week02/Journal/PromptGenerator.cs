
public class PrompGenerator
{
    public List<String> _prompts = new List<String>();

    public PrompGenerator()
    {
        _prompts.Add("Something that you are gratefull about today");
        _prompts.Add("Tell me about one thing that make you smile today");
        _prompts.Add("what did you learn today?");
        _prompts.Add("Somedthing that you wished to do better?");
        _prompts.Add("Something that makes you feel stresed?");
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int _index = randomPrompt.Next(_prompts.Count);
        string _prompt = _prompts[_index];
        return _prompt;
    }
}