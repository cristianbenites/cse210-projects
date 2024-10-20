public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _askedQuestions = new List<string>();
    private Random _random = new Random();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts =
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        ];

        _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        ];
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
        }
    }

    private string GetRandomPrompt()
    {
        return _prompts.ElementAt(_random.Next(_prompts.Count));
    }

    private string GetRandomQuestion()
    {
        if(_questions.Count > 0)
        {
            int index = _random.Next(_questions.Count);
            string selected = _questions.ElementAt(index);

            _askedQuestions.Add(selected);
            _questions.RemoveAt(index);
            
            return selected;
        }

        _questions = _askedQuestions;
        _askedQuestions = [];

        return GetRandomQuestion();
    }
}