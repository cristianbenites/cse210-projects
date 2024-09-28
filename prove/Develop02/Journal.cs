using System.IO;

public class Journal
{
    public bool _systemIsRunning = true;
    public UserMenu _userMenu = new UserMenu();
    public PromptGenerator _promptGenerator = new PromptGenerator();

    public List<Entry> _entries = new List<Entry>();

    public bool SystemIsRunning()
    {
        return _systemIsRunning;
    }

    public void Run()
    {
        Option option = _userMenu.GetUserOption();

        if (option == Option.Quit)
        {
            _systemIsRunning = false;
            return;
        }

        if (option == Option.Write)
        {
            Write();
        }

        if (option == Option.Display)
        {
            _entries.ForEach(entry => {
                entry.Display();
                Console.WriteLine("");
            });
        }

        if (option == Option.Load)
        {
            Load();
        }

        if (option == Option.Save)
        {
            Save();
        }

    }

    public void Write()
    {
        string prompt = _promptGenerator.GetPromt();

        Console.WriteLine(prompt);
        string answer = Console.ReadLine();

        DateTime current = DateTime.Now;

        _entries.Add(new Entry(
            current.ToShortDateString(),
            prompt,
            answer
        ));
    }

    public void Load()
    {
        string filename = GetFileName();
        string[] lines = File.ReadAllLines(filename);
        _entries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            _entries.Add(new Entry(
                parts[0],
                parts[1],
                parts[2]
            ));
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            _entries.ForEach(entry => 
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._answer}"));
        }

        Console.WriteLine($"Entries attached to file {filename}");
    }

    public string GetFileName()
    {

        Console.WriteLine("What is the filename? (defaul 'journal.txt')");
        string filename = Console.ReadLine();

        if (filename == "")
        {
            filename = "journal.txt";
        }

        return filename;
    }
}