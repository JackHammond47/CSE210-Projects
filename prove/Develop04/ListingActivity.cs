using System;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();
    private int _actualDuration = 0;
    private Random _random = new Random();
    public ListingActivity(string activity, int duration) : base(activity, duration)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Startlisting()
    {
        base.Start();
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine("Get ready...");
        Spinner();
        Console.WriteLine();
        int duration = GetDuration();
        PromptGenerator();
        Console.WriteLine();
        Spinner();
        Console.WriteLine($"Now you have {duration} seconds to list as many things as possible.");
        Spinner();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        int count = 0;
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            string new_item = Console.ReadLine();
            _responses.Add(new_item);
            count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine($"Congrats you listed {count} many things!");
        _actualDuration = duration + 10;
        SetDuration(_actualDuration);
    }
    private void PromptGenerator()
    {
        int randomIndex = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine(randomPrompt);
    }
}