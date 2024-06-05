public class OutdoorGatherubg : Event
{
    protected string _weather;
    public OutdoorGatherubg(string weather, string title, string description, string date, string time, Address address, int participants)
    {
        _weather = weather;
        
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _adderess = address;
        _participants = participants;

    }
    public void GetFullDetails()
    {
        Console.WriteLine($"{_title} - {_description} \n{_date} @ {_time}\n{_adderess.GetAddress()} \nWeather: {_weather}");
    }
}