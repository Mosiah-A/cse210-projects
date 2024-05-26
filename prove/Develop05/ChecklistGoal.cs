public class ChecklistGoal : Goal 
{
    // Attributes
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
         
        // If we previously were not complete
        //then mark complete and return points
        if (_amountCompleted == _target -1)
        {
            return _points + _bonus;
        }
        else 
        {
            _amountCompleted = _amountCompleted + 1;
            return _points;
        }
    }
    public override bool IsComplete()
    {
        //return back whether this goal is complete or not
        if (_amountCompleted == _target)
        {
            return  true;

        }
        else{
            return false;
        }
    }
   
    public override string GetStringRepresentation()
    {
        if (_amountCompleted == _target)
        {
            return ($"[x] {GetDetailsString()} -- {_amountCompleted}/{_target}");
        }
        else
        {
            return ($"[ ] {GetDetailsString()} -- {_amountCompleted}/{_target}");
        }
    }
    public override string GetNameDetail()
    {
        return ($"{GetName()} ");
    }
 public override string Savestring()
    {
        return $"~EternalGoal~{GetNameDetail()}~{_points}~{_bonus}~{_target}~{_amountCompleted}~";
    }
}