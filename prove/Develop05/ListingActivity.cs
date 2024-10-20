public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _userList = [];

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            GetListItemsFromUser();
        }

        Console.WriteLine($"You listed {_userList.Count} item{(_userList.Count != 1 ? "s" : "")}!");
    }

    private void GetListItemsFromUser()
    {
        Console.Write("> ");
        _userList.Add(Console.ReadLine());
    }

    private string GetRandomPrompt()
    {
        return _prompts.ElementAt(new Random().Next(_prompts.Count));
    }

}