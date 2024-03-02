using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private int _actualDuration = 0;
    private int _countOfReflections = 0;
    private Random _random = new Random();

    public ReflectionActivity(string activity, int duration) : base(activity, duration)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void StartReflection()
    {
        base.Start();
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine("Get ready...");
        Spinner();
        Console.WriteLine();
        int duration = GetDuration();
        while (duration >= 0)
        {
            PromptGenerator();
            Console.WriteLine();
            Spinner();
            Spinner();
            duration -= 4;
            QuestionGenerator();
            Console.WriteLine();
            Spinner();
            Spinner();
            duration -= 4;
            Console.Write("Think about it for a little bit. ");
            Countdown(10);
            Console.WriteLine();
            Console.WriteLine();
            duration -= 10;
            _countOfReflections += 1;
        }

        Spinner();
        _actualDuration = (_countOfReflections * 18) + 4;
        SetDuration(_actualDuration);
    }

    private void PromptGenerator()
    {
        int randomIndex = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine(randomPrompt);
    }

    private void QuestionGenerator()
    {
        int randomIndex = _random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        Console.WriteLine(randomQuestion);
    }
}
