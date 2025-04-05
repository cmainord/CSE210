public class Lecture(string title, string description, Date date, Time time, Address address, string speaker, int capacity)
: Event(title, description, date, time, address)
{
    private string _speaker = speaker;
    private int _capacity = capacity;

    public override string GetFullDetails()
    {
        string details = $"{GetEventType()} by {_speaker} - {_title}\n\t{_description}\n\t{_address.GetLocalAddress()}\n\t{_time.GetClockDisplay()} on {_date.GetDateDisplay()}\n\tCapacity: {_capacity}";
        return details;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }

}