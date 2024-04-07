namespace Goals{
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue)
        : base(name, description, pointValue)
    {
    }
    public override string Save()
    {
        return $"SimpleGoal:{Name},{Description},{PointValue},{CompletionStatus}";
    }
    public static SimpleGoal Load(string values)
    {
        string[] parameters = values.Split(',');
        return new SimpleGoal(parameters[0], parameters[1], int.Parse(parameters[2]))
        {
            CompletionStatus = int.Parse(parameters[3])
        };
    }
        public override int RecordEvent()
        {
            if(CompletionStatus == 0){
                CompletionStatus++;
                return PointValue;
            }
            Console.WriteLine("Not so fast kiddo, you can only do this once.");
            return 0;
        }
    }
}