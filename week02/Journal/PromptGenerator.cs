using System;
public class PromptGenerator{
    public List<string> _prompts = new List<string>();

    public PromptGenerator(){
        _prompts.Add("Tell me a blessing from the Lord that you saw today");
        _prompts.Add("Something new that you learned today?");
        _prompts.Add("What could you do wish to do diferent today?");
        _prompts.Add("any goals that you have?");
        _prompts.Add("tell me something to make smile somebody else");
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        int randomNumber = random.Next(0,_prompts.Count);
        string _selectedPrompt = _prompts[randomNumber];
        
        return _selectedPrompt;
    }
    
}