using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int timesCompleted)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
            {
                return GetPoints() + _bonusPoints;
            }
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetDisplayString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_targetCount}|{_bonusPoints}|{_timesCompleted}";
    }
}
