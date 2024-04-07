namespace Goals{
public class ChecklistGoal : Goal
{
    public int CompletionAmount { get; set; }
    public int CompletionBonus { get; set; }

    public ChecklistGoal(string name, string description, int pointValue, int completionAmount, int completionBonus)
        : base(name, description, pointValue)
    {
        CompletionAmount = completionAmount;
        CompletionBonus = completionBonus;
    }
    public override string CheckCompleted()
    {
        return CompletionStatus == CompletionAmount ? "[X]" : "[ ]";
    }
    public string ChecklistCompletion()
    {
        return $"-- Currently completed: {CompletionStatus}/{CompletionAmount}";
    }
    public override void ListGoal(int index)
    {
        Console.WriteLine($"{index + 1}. {CheckCompleted()} {Name} ({Description}) {ChecklistCompletion()}");
    }
    public override string Save()
    {
        return $"ChecklistGoal:{Name},{Description},{PointValue},{CompletionStatus},{CompletionAmount},{CompletionBonus}";
    }
    public static ChecklistGoal Load(string values)
    {
        string[] parameters = values.Split(',');
        return new ChecklistGoal(parameters[0], parameters[1], int.Parse(parameters[2]),int.Parse(parameters[4]), int.Parse(parameters[5]))
        {
            CompletionStatus = int.Parse(parameters[3])
        };
    }
    public override int RecordEvent()
        {
            if(CompletionStatus < CompletionAmount){
                CompletionStatus++;
                if (CompletionStatus == CompletionAmount)
                {
                    Console.WriteLine($"Congrats, you finished the checklist and earned an extra {CompletionBonus} points!!");
                    return PointValue + CompletionBonus;
                }
                return PointValue;
            }
            Console.WriteLine("Not so fast kiddo, you already finished the checklist.");
            return 0;
        }

}
}