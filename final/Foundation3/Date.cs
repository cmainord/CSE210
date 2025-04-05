public class Date(int month, int day, int year)
{
    private int _month = month;
    private int _day = day;
    private int _year = year;

    public string GetMonthName()
    {
        string name = "(month)";
        switch (_month)
        {
            case 1:
                name = "January";
                break;
            case 2:
                name = "February";
                break;
            case 3:
                name = "March";
                break;
            case 4:
                name = "April";
                break;
            case 5:
                name = "May";
                break;
            case 6:
                name = "June";
                break;
            case 7:
                name = "July";
                break;
            case 8:
                name = "August";
                break;
            case 9:
                name = "September";
                break;
            case 10:
                name = "October";
                break;
            case 11:
                name = "November";
                break;
            case 12:
                name = "December";
                break;
        }
        return name;
    }

    public string GetDateDisplay(bool includeYear = false)
    {
        string yearString = "";
        if (includeYear)
        {
            yearString = $", {_year}";
        }

        string display = $"{GetMonthName()} {_day}{yearString}";
        return display;
    }

}