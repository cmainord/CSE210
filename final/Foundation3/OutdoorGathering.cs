public class OutdoorGathering(string title, string description, Date date, Time time, Address address, string weather)
: Event(title, description, date, time, address)
{
    private string _weather = weather;

    public override string GetFullDetails()
    {
        string details = $"{GetEventType()} - {GetStandardDetails()}\n\tprepare for {_weather} weather";
        return details;
    }

    public override string GetEventType()
    {
        return "OutdoorGathering";
    }

}