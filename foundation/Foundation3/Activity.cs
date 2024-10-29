public abstract class Activity
{
    protected string _date;
    protected int _lengthInMinutes;

    protected Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public string GetSummary()
    {
        return $"${_date} {GetName()} ({_lengthInMinutes} min) - " +
            $"Distance {GetDistance():0.00} km, " + 
            $"Speed {GetSpeed():0.00} kph, " +
            $"Pace {GetPace():0.00} min per km";
    }

    protected double GetSpeed()
    {
        return GetDistance() / _lengthInMinutes * 60;
    }

    protected double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }

    protected abstract double GetDistance();

    protected abstract string GetName();
}