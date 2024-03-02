using System;

class Activity
{
    private string _activityName;
    private int _duration;

    public Activity(string activityName, int duration)
    {
        _activityName = activityName;
        _duration = duration;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_activityName}...");
        Console.WriteLine();
        Spinner();
        Console.WriteLine();
        // Perform any initialization or setup for the activity
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void End()
    {
        Console.WriteLine($"Ending {_activityName}...");
        Spinner();
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Thread.Sleep(400);
        // Perform any cleanup or finalization for the activity
        Console.WriteLine($"You have completed {_duration} seconds of {_activityName}.");
        Console.WriteLine();
        Thread.Sleep(400);
    }
    
    public void Spinner()
    {
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("|");
        Console.Write("\b \b");
        Thread.Sleep(250);
    }

    public void Countdown(int seconds)
    {
         Console.Write($"Countdown: ");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
            if (i > 9)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
        Console.Write("\b \b");
        Console.WriteLine();
    }
}
