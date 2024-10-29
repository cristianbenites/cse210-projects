public class SwimmingActivity : Activity
{
    private double _numberOfLaps;

    public SwimmingActivity(string date, int lengthInMinutes, double numberOfLaps) : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    protected override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    protected override string GetName()
    {
        return "Swimming";
    }
}