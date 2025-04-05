public class Comment(string username, string text)
{
    private string _username = username;
    private string _text = text;

    public void Display()
    {
        Console.WriteLine($"\t{_username}:\n\t\t{_text}");
    }
}