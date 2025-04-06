public class Entry(string date, string prompt, string response)
{
    private string _date = date;
    private string _prompt = prompt;
    private string _response = response;

    public string GetDate()
    {
        return _date;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }
}