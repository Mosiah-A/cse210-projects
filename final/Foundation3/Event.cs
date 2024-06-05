public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _adderess;
    protected int _participants;

    public Event()
    {
    }
    public void GetStandardDetails()
    {
        Console.WriteLine($"{_title} - {_description} \n{_date} @ {_time}\n{_adderess.GetAddress()}");
    }
    public void GetShortDescription()
    {
        Console.WriteLine($"{_title} - {_description} - {_date} ");
        
    }
}