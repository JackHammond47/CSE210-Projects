class SwimmingActivity : Activity
{
    public int NumLaps { get; set; }
    public SwimmingActivity(DateTime date, int duration, int numLaps) : base(date, duration)
    {
        NumLaps = numLaps;
    }
    public override double GetDistance()
    {
        return NumLaps * 50 / 1000 *0.62;
    }
    public override double GetSpeed()
    {
        double pace = GetPace();
        return pace / 60;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return Duration / distance;
    }
    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({Duration} min)- Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}