public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    protected override double GetDistance()
    {
        return _distance;
    }

    protected override string GetName()
    {
        return "Running";
    }
}