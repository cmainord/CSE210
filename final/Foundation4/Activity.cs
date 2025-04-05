public abstract class Activity(Date date, Time duration)
{
    protected Date _date = date;
    protected Time _duration = duration;

    public abstract string GetActivityType();
    public abstract float GetDistanceMiles();

    public string GetSummary()
    {
        return $"{_date.GetDateDisplay(true)} {GetActivityType()}({_duration.GetCounterDisplay()})-"
            + $"Distance {GetDistanceMiles():0.00} miles, Speed {GetSpeedMiles():0.00} mph, Pace: {GetPaceMiles():0.00} min per mile";
    }
    
    public virtual float GetSpeedMiles()
    {
        return GetDistanceMiles() / (_duration.GetTimeSeconds()/60/60);
    }

    public float GetPaceMiles()
    {
        return _duration.GetTimeMinutes() / GetDistanceMiles();
    }

    public float GetDurationSeconds()
    {
        return _duration.GetTimeSeconds();
    }

    public string GetDurationDisplay()
    {
        return _duration.GetCounterDisplay();
    }
}