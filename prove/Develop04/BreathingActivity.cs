using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string activity, int duration) : base(activity, duration)
    {

    }
    private int _actualDuration = 0;
    private int _countOfBreaths = 0;

    public void StartBreathing()
    {
        base.Start();
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine("Get ready...");
        Spinner();
        int duration = GetDuration();
        while (duration >= 0)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in");
            Countdown(4);
            Console.WriteLine();
            Console.WriteLine("Breathe out");
            Countdown(4);
            duration -= 8;
            _countOfBreaths += 1;
        }
        Console.WriteLine();
        Spinner();
        _actualDuration = (_countOfBreaths * 8) + 4;
        SetDuration(_actualDuration);
    }
}