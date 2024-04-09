class LectureEvent : Event
{
    //speaker, limitedCapacity
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string desc, string date, string time, Address address,string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetFullDetails()
    {
        //return title, desc, date, time, address
        //also with event specific details
        return $"What: {Title} ({Desc}) \nWhen: {Date}, at {Time} \nWhere: {Address.GetFullAddress()} \nFeaturing: {_speaker} \nSeating Capacity: {_capacity}";
    }
}