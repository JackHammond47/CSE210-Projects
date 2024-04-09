class ReceptionEvent : Event
{
    //require RSVP beforehand
    private string _email;

    public ReceptionEvent(string title, string desc, string date, string time, Address address,string email) : base(title, desc, date, time, address)
    {
        _email = email;
    }
    public string GetFullDetails()
    {
        //return title, desc, date, time, address
        //also with event specific details
        return $"What: {Title} ({Desc}) \nWhen: {Date}, at {Time} \nWhere: {Address.GetFullAddress()} \nPlease RSVP at {_email}";
    }
}