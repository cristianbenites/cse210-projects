public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    protected override double GetDistance()
    {
        return _speed / 60 * _lengthInMinutes;
    }

    protected override string GetName()
    {
        return "Cycling";
    }
}