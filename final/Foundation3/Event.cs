class Event
{
    public Address Address { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public Event(string title, string desc, string date, string time, Address address)
    {
        Title = title;
        Desc = desc;
        Date = date;
        Time = time;
        Address = address;
    }
    public string GetStandardDetails()
    {
        //return title, desc, date, time, address
        return $"What: {Title} ({Desc}) \nWhen: {Date}, at {Time} \nWhere: {Address.GetFullAddress()}";
    }
    public string GetShortDesc(string eventType)
    {
        //return eventType, title, date
        return $"Come join us for {Title}, a {eventType} on {Date}!";
    }

}