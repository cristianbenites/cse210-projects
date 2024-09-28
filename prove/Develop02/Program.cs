class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while(journal.SystemIsRunning())
        {
            journal.Run();
        }
        
    }
}