public class Video
{
    private string _name;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string name, string author, int lengthInSeconds)
    {
        _name = name;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayText()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration (in seconds): {_lengthInSeconds}");
        Console.WriteLine("Comments");
        _comments.ForEach(comment => {
            comment.DisplayText();
        });
        Console.WriteLine();
    }

}