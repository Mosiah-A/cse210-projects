public abstract class Activity
{
    protected string _date;
    protected double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public abstract string GetSummary();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

}
    