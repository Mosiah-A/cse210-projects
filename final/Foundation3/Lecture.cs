public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;
    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address, int participants)
    {
        _speaker = speaker;
        _capacity = capacity;
        
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _adderess = address;
        _participants = participants;

    }
    public void GetFullDetails()
    {
        
        Console.WriteLine($" {_title} - {_description} \n{_date} @ {_time}\n{_adderess.GetAddress()} \nSpeaker: {_speaker}\nCapacity: {_capacity}");
    }
}
