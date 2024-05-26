public abstract class Goal
{
    // Attributes
    private string _shortName;
    private string _description;
    protected int _points;

    // contructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }
    public int Getpoint(){
        return _points;
        
    }
    public abstract string GetNameDetail();
    public abstract string Savestring();
}