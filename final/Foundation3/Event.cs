public abstract class Event (string title, string description, Date date, Time time, Address address)
{

    protected string _title = title;
    protected string _description = description;
    protected Date _date = date;
    protected Time _time = time;
    protected Address _address = address;

    public abstract string GetEventType();
    public abstract string GetFullDetails();
    public string GetStandardDetails()
    {
        string details = $"{_title}\n\t{_description}\n\t{_address.GetLocalAddress()}\n\t{_time.GetClockDisplay()} on {_date.GetDateDisplay()}";
        return details;
    }

    public string GetShortDetails()
    {
        string details = $"{_title} - {GetEventType()} - {_date.GetDateDisplay()}";
        return details;
    }

    public string GetDateDisplay()
    {
        return _date.GetDateDisplay();
    }

    public string GetAddressDisplay()
    {
        return _address.GetLocalAddress();
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Short Details:\n{GetShortDetails()}\n\nStandard Details:\n{GetStandardDetails()}\n\nFull Details:\n{GetFullDetails()}");
    }
}