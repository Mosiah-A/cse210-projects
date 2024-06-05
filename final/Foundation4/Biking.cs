public class Biking : Activity
{
    private double _speed;
    public Biking(string date, double minutes, double speed) : base (date, minutes)
    {
        _date = date;
        _minutes = minutes;
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes}) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}