public class EternalGoal : Goal 
{

    // Constructor
    public EternalGoal(string name, string description, int points) : base(name,description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        //return back whether this goal is complete or not
        return false;
    }
   
    public override string GetStringRepresentation()
    {
        return ($"[ ] { GetDetailsString()}");
    }

    public override string GetNameDetail()
    {
        return ($"{GetName()}");
    }

    public override string Savestring()
    {
        return $"~EternalGoal~{GetNameDetail()}~{_points}";

    }
}