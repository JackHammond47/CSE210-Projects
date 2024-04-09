class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    public Address(string streetAddress, string city, string stateProvince)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}";
    }
}