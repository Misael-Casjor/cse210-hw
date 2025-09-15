using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        PromptGenerator prompt = new PromptGenerator();
        string _thePrompt = prompt.RandomPrompt();
        Console.WriteLine(_thePrompt);
    }
}