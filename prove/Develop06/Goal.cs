public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description})";
    }
}