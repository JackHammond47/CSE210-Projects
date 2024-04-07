namespace Goals{
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue)
        : base(name, description, pointValue)
    {
    }
    public override string CheckCompleted()
    {
        return "[ ]";
    }
    public override string Save()
    {
        return $"EternalGoal:{Name},{Description},{PointValue},{CompletionStatus}";
    }
    public static EternalGoal Load(string values)
    {
        string[] parameters = values.Split(',');
        return new EternalGoal(parameters[0], parameters[1], int.Parse(parameters[2]))
        {
            CompletionStatus = int.Parse(parameters[3])
        };
    }

}
}