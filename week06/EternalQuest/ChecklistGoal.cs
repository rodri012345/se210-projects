public class ChecklistGoal : Goal{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int timesCompleted = 0) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent(){
        _timesCompleted++;
        if (_timesCompleted == _target){
            return _points + _bonus;
        }
        else if (_timesCompleted < _target){
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetStatus() => $"[{_timesCompleted}/{_target}]";

    public override string GetStringRepresentation(){
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_target}|{_bonus}|{_timesCompleted}";
    }
}
