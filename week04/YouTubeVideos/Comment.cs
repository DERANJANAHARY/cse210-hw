class Comment
{
    // Tracks the name of the commenter and the text of the comment
    string _name;
    string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    // Prints name and comment together (void as requested)
    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_commentText}");
    }
}
