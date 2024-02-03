using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // public string[] _prompts = new string[]
    // {
    //     "Who was the most interesting person I interacted with today?",
    //     "What was the best part of my day?",
    //     "How did I see the hand of the Lord in my life today?",
    //     "What was the strongest emotion I felt today?",
    //     "If I had one thing I could do over today, what would it be?"
    // };
    public static List<string> _prompts = new List<string>();
    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int length = _prompts.Count;
        int index = random.Next(length);
        return _prompts.ElementAt(index);
    }
    public void GetPromptList()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
    public void addToPrompts(string newPrompt)
    {
        _prompts.Add(newPrompt);
    }
}