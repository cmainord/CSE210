public class Address(string streetAddress, string city, string stateProvince, string country)
{
    private string _streetAddress = streetAddress;
    private string _city = city;
    private string _stateProvince = stateProvince;
    private string _country = country;

    public string GetFullAddress()
    {
        string address = $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
        return address;
    }

    public bool IsInUnitedStates()
    {
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}