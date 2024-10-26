using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private bool _systemIsRunning = true;
    private Dictionary<string, MenuOption> _options;

    public GoalManager()
    {
        _options = new Dictionary<string, MenuOption>
        {
            { "1", new MenuOption("Create New Goal", CreateGoal) },
            { "2", new MenuOption("List Goals", ListGoalDetails) },
            { "3", new MenuOption("Save Goals", SaveGoals) },
            { "4", new MenuOption("Load Goals", LoadGoals) },
            { "5", new MenuOption("Record Event", RecordEvent) },
            { "6", new MenuOption("Quit", Quit) },
        };

        _goals = new List<Goal>();
    }

    public void Start()
    {
        while (_systemIsRunning)
        {
            DisplayPlayerInfo();
            string userChoice = Console.ReadLine();
            CallUserAction(userChoice);
        }
    }

    private void CallUserAction(string choice)
    {
        if (_options.TryGetValue(choice, out var cmd))
        {
            cmd.Action();
        }
        else
        {
            Console.WriteLine($"The option \"{choice}\" does not exist.");
            Thread.Sleep(1000);
        }
    }

    private void Quit()
    {
        _systemIsRunning = false;
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");

        Console.WriteLine("Menu Options:");
        foreach (var option in _options)
        {
            Console.WriteLine($"  {option.Key}. {option.Value.Description}");
        }
    }

    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i+1}. {_goals[i].GetName()}");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i+1}. [{(_goals[i].IsComplete() ? "x" : " " )}] {_goals[i].GetDetailsString()}");
        }

        Thread.Sleep(2000);
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Negative Goal (you lose points when you do it)");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        if(choice != "1" && choice != "2" && choice != "3" && choice != "4")
        {
            Console.WriteLine($"There is no option for '{choice}. Please, write a number.'");
            Thread.Sleep(500);
            return;
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string stringPoints = Console.ReadLine();
        int points = int.Parse(stringPoints);

        if(choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        if(choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        if(choice == "3")
        {
            Console.Write("What many times does this goal need to be accomplished for a bonus? ");
            string times = Console.ReadLine();

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();

            _goals.Add(new ChecklistGoal(name, description, points, int.Parse(times), int.Parse(bonus)));
        }

        if(choice == "4")
        {
            _goals.Add(new NegativeGoal(name, description, points));
        }

        Console.WriteLine();
    }

    private void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        string stringAccomplished = Console.ReadLine();
        int accomplished = int.Parse(stringAccomplished);

        Goal goal = _goals[accomplished-1];
        int pointsEarned = goal.RecordEvent();

        _score += pointsEarned;

        string message = $"Congratulations! You have earned {pointsEarned} points!";

        if (pointsEarned == 0)
        {
            message = "It seems that you chose a goal that is already completed.\n";
        }

        if (pointsEarned < 0)
        {
            message = $"Sorry! You lost {pointsEarned * -1} points.";
        }

        Console.WriteLine(message);

        Console.WriteLine($"You now have {_score} points.\n");
        Thread.Sleep(1000);
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split("::");

            if(parts.Length > 1)
            {
                _goals.Add(GoalFactory.FromStringRepresentation(parts[0], parts[1].Split(";;")));
            }
        }
    }

    private class MenuOption
    {
        public string Description;
        public Action Action;

        public MenuOption(string description, Action action)
        {
            Description = description;
            Action = action;
        }
    }
}