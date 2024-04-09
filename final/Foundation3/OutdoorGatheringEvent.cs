class OutdoorGatheringEvent : Event
{
    //no limit, but need to track weather
    private string _weather;

    public OutdoorGatheringEvent(string title, string desc, string date, string time, Address address,string weather) : base(title, desc, date, time, address)
    {
        _weather = weather;
    }
    public string GetFullDetails()
    {
        //return title, desc, date, time, address
        //also with event specific details
        return $"What: {Title} ({Desc}) \nWhen: {Date}, at {Time} \nWhere: {Address.GetFullAddress()} \nThe weather will be {_weather}";
    }
}