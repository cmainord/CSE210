public class Reception(string title, string description, Date date, Time time, Address address, string email)
: Event(title, description, date, time, address)
{
    private string _email = email;

    public override string GetFullDetails()
    {
        string details = $"{GetEventType()} - {GetStandardDetails()}\n\tRSVP at: {_email}";
        return details;
    }

    public override string GetEventType()
    {
        return "Reception";
    }

}