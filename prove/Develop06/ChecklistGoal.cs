public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            return 0;
        }
        _amountCompleted++;

        int pointsEarned = _points;

        if (_amountCompleted == _target)
        {
            pointsEarned += _bonus;
        }

        return pointsEarned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal::{_name};;{_description};;{_points};;{_target};;{_bonus};;{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Currently completed: {_amountCompleted}/{_target}";
    }
}