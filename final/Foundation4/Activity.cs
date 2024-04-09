abstract class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; }
    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} ACTIVITY ({Duration} min)- Distance {GetDistance():1f} miles, Speed {GetSpeed():1f} mph, Pace: {GetPace():2f} min per mile";
    }
}