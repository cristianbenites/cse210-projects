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

    public string GetName()
    {
        return _name;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _lengthInSeconds;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        _comments.ForEach(comment => {
            comment.DisplayText();
        });
    }

}