class Customer
{
    public string Name { get; set; }
    public Address Address{ get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
    public bool IsFromUSA()
    {
        //if address from USA true else false
        if (Address.GetCountry() == "USA")
        {
            return true;
        }
        return false;
    }
}