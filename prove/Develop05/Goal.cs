namespace Goals{
public abstract class Goal
{
    public string Name { get; set; }

    public string Description { get; set; }
    public int PointValue { get; set; }
    public int CompletionStatus { get; set; } // 0 for incomplete, 1 for complete

    public Goal(string name, string description, int pointValue)
    {
        Name = name;
        Description = description;
        PointValue = pointValue;
        CompletionStatus = 0; // Initialize completion status as incomplete
    }
    public virtual string CheckCompleted()
    {
        return CompletionStatus != 0 ? "[X]" : "[ ]";
    }
    public virtual void ListGoal(int index)
    {
        
        Console.WriteLine($"{index + 1}. {CheckCompleted()} {Name} ({Description})");
    }
    public virtual int RecordEvent()
    {
        CompletionStatus++;
        return PointValue;
    }

    public abstract string Save();
    
}
}