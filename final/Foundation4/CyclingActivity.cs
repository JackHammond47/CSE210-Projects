class CyclingActivity : Activity
{
    public double Speed { get; set; }
    public CyclingActivity(DateTime date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }
    public override double GetDistance()
    {
        return Speed * Duration / 60;
    }
    public override double GetSpeed()
    {
        return Speed;
    }
    public override double GetPace()
    {
        return 60 / Speed;
    }
    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({Duration} min)- Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}