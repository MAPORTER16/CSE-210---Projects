using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDisplayString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}
