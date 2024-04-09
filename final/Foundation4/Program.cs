using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new RunningActivity(new DateTime(2024, 04, 03), 30, 4.2),
            new CyclingActivity(DateTime.Now, 75, 17),
            new SwimmingActivity(new DateTime(2024, 04, 06), 120, 65)
        };
        foreach (Activity activity in activities)
            Console.WriteLine(activity.GetSummary());
    }
}