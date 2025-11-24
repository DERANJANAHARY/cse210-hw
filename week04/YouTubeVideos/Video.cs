class Video
{
    // Fields (no explicit 'private' keyword)
    string _title;
    string _author;
    int _length;

    // List of comments
    public List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Adds a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Prints how many comments exist (void as requested)
    public void PrintNumberOfComments()
    {
        Console.WriteLine($"Number of comments: {_comments.Count}");
    }

    // Prints basic video info 
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}, {_length} seconds");
    }
}