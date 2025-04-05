public class Video(string title, string author, Time length, List<Comment> comments)
{
    private string _title = title;
    private string _author = author;
    private Time _length = length;
    private List<Comment> _comments = comments;

    public int GetCommentQuantity()
    {
        return _comments.Count;
    }

    public string GetLengthDisplay()
    {


        string lengthDisplay = "";
        return lengthDisplay;
    }


    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Length: {_length.GetCounterDisplay()}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Comments ({GetCommentQuantity()}):");

        foreach(Comment comment in _comments)
        {
            comment.Display();
        }
    }
}