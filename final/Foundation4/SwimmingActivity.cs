public class SwimmingActivity(Date date, Time duration, float laps) 
: Activity(date, duration)
{
    float _laps = laps;

    public override string GetActivityType()
    {
        return "Swimming";
    }

    public override float GetDistanceMiles()
    {
        return _laps * 50 / 1000 * 0.62f;
    }
}