using System;



public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected string Date { get => _date; }
    protected int Minutes { get => _minutes; }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public virtual double GetPace()
    {
        return Minutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F2} min per km";
    }
}