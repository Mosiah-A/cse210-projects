using System.Drawing;

public class SimpleGoal : Goal 
{
    //attributes
    private bool _IsComplete = false;

    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name,description, points)
    {
    }

    public override int RecordEvent()
    {
        
        // If we previously were not complete
        //then mark complete and return points
        if (!_IsComplete)
        {
            _IsComplete = true;
            return _points;
        }
        else 
        {
            // what if we previously were complete?
            Console.Write("It's previously were complete");
            return 0;
        }

        
    }

    public override bool IsComplete()
    {
        //return back whether this goal is complete or not
        _IsComplete = true;
        return true;
    }
    public override string GetStringRepresentation()
    {

        if (_IsComplete == false)
        {
            return ($"[ ] { GetDetailsString()}");
        }
        else
        {
            return ($"[x] { GetDetailsString()}");

        }
    }
    public override string GetNameDetail()
    {
        return ($"{GetName()}");
    }
    public override string Savestring()
    {
        return $"~SimpleGoal~{GetDetailsString()}~{_points}~{IsComplete()}~";
    }
}