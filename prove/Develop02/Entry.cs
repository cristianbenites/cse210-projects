public class Entry
{
    public string _date;
    public string _prompt;
    public string _answer;

    public Entry(string date, string promt, string answer)
    {
        _date = date;
        _prompt = promt;
        _answer = answer;
    }

    public void Display()
    {
        Console.Write($"Date: {_date}");
        Console.WriteLine($" - Prompt: {_prompt}");
        Console.WriteLine($"{_answer}");
    }
}