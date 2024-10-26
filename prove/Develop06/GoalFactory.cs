public class GoalFactory
{
    public static Goal FromStringRepresentation(string name, string[] body)
    {
        if (name == "Simple Goal")
        {
            return new SimpleGoal(body[0], body[1], int.Parse(body[2]), bool.Parse(body[3]));
        }

        if (name == "Eternal Goal")
        {
            return new EternalGoal(body[0], body[1], int.Parse(body[2]));
        }

        if (name == "Checklist Goal")
        {
            return new ChecklistGoal(body[0], body[1], int.Parse(body[2]), int.Parse(body[3]), int.Parse(body[4]), int.Parse(body[5]));
        }

        if (name == "Negative Goal")
        {
            return new NegativeGoal(body[0], body[1], int.Parse(body[2]));
        }

        throw new Exception($"There is no goal of type \"{name}\"");
    }
}