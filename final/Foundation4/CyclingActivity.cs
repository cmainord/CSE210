public class CyclingActivity(Date date, Time duration, float speedMilesPerHour) 
: Activity(date, duration)
{
    private float _speedMilesPerHour = speedMilesPerHour;

    public override string GetActivityType()
    {
        return "Cycling";
    }

    public override float GetDistanceMiles()
    {
        return _speedMilesPerHour * (_duration.GetTimeMinutes()/60);
    }

    public override float GetSpeedMiles()
    {
        return _speedMilesPerHour;
    }
}