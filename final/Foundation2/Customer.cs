public class Customer
{
    private Address _address;
    private string _name;
    public Customer(string street, string city, string stateProv, string country, string name)
    {
        _address = new Address(street, city, stateProv, country);
        _name = name;
    }

    public bool LivingInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetShippingAddress()
    {
        return $"{_name} \n{_address.GetAddress()}";
    }
}