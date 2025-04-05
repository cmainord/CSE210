public class RunningActivity(Date date, Time duration, float distanceMiles) 
: Activity(date, duration)
{
    private float _distanceMiles = distanceMiles;

    public override string GetActivityType()
    {
        return "Running";
    }

    public override float GetDistanceMiles()
    {
        return _distanceMiles;
    }
}