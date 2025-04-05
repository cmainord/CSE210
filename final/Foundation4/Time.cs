public class Time
{
    private int _second;
    private int _minute;
    private int _hour;
    private int _day;

    public Time(int second, int minute, int hour, int day = 0)
    {
        _second = second;
        _minute = minute;
        _hour = hour;
        _day = day;
        ParseTime();
    }

    public Time()
    {
        _second = 0;
        _minute = 0;
        _hour = 0;
        _day = 0;
    }

    public float GetTimeSeconds()
    {
        return _second + (_minute * 60) + (_hour * 60 * 60) + (_day * 24 * 60 * 60);
    }

    public float GetTimeMinutes()
    {
        return ((float)_second / 60) + _minute + (_hour * 60) + (_day * 24 * 60);
    }

    public string GetClockDisplay(bool showSeconds = false, bool inMilitaryTime = false)
    {
        string secondDisplay;
        if(showSeconds)
        {
            secondDisplay = $":{GetPartialDisplay(_second)}";
        }
        else
        {
            secondDisplay = "";
        }

        if(inMilitaryTime)
        {
            return $"{GetPartialDisplay(_hour)}:{GetPartialDisplay(_minute)}{secondDisplay}";
        }
        else
        {
            if(_hour > 12)
            {
                return $"{_hour - 12}:{GetPartialDisplay(_minute)}:{secondDisplay} PM";
            }
            else
            {
                return $"{_hour}:{GetPartialDisplay(_minute)}:{secondDisplay} AM";
            }
        }
    }

    public string GetCounterDisplay(bool showDays = false)
    {
        if(showDays)
        {
            return $"{GetPartialDisplay(_day)}:{GetPartialDisplay(_hour)}:{GetPartialDisplay(_minute)}:{GetPartialDisplay(_second)}";
        }
        else
        {
            return $"{GetPartialDisplay(_hour+(_day*24))}:{GetPartialDisplay(_minute)}:{GetPartialDisplay(_second)}";
        }
    }

    private void ParseTime()
    {
        if(_second >= 60)
        {
            _second -= 60;
            _minute += 1;
        }

        if(_minute >= 60)
        {
            _minute -= 60;
            _hour += 1;
        }

        if(_hour >= 24)
        {
            _hour -=24;
            _day +=1;
        }
    }

    /*
    This takes one element of the full time display and, if it has fewer than 2 digits,
    it adds a 0 digit in front of it in keeping with standard time display practices.
    */
    private string GetPartialDisplay(int time)
    {
        string display;
        if (time >= 10)
        {
            display = $"{time}";
        }
        else
        {
            display = $"0{time}";
        }
        return display;
    }
}