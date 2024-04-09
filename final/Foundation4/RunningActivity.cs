class RunningActivity : Activity
{
    public double Distance { get; set; }
    public RunningActivity(DateTime date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }
    public override double GetDistance()
    {
        return Distance;
    }
    public override double GetSpeed()
    {
        return Distance / Duration * 60;
    }
    public override double GetPace()
    {
        double speed = GetSpeed();
        return speed / 60;
    }
    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({Duration} min)- Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}