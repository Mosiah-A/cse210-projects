public class Swimming : Activity
{
    private double _lapes;
    public Swimming(string date, double minutes, double lapes) : base (date, minutes)
    {
        _date = date;
        _minutes = minutes;
        _lapes = lapes;
    }
    public override double GetDistance()
    {
        return _lapes * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (_lapes * 50 / 1000 * 0.62) * 60;
    }
    public override double GetPace()
    {
        return _minutes / (_lapes * 50 / 1000 * 0.62);
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes}) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}