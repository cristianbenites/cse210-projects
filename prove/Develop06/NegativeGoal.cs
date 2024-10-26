public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetStringRepresentation()
    {
        return $"Negative Goal::{_name};;{_description};;{_points}";
    }

    public override string GetDetailsString()
    {
        return "(Bad Habit): "+ base.GetDetailsString();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return _points * (-1);
    }
}