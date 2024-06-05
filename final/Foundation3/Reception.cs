public class Reception : Event
{
    protected string _email;
    public Reception(string email, string title, string description, string date, string time, Address address, int participants)
    {
        _email = email;
        
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _adderess = address;
        _participants = participants;

    }
    public void GetFullDetails()
    {
        
        Console.WriteLine($"{_title} - {_description} \n{_date} @ {_time}\n{_adderess.GetAddress()} \nEmail: {_email}");
    }
    

}