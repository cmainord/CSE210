public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, List<int> durationOptions)
    : base (name, description, durationOptions)
    {

    }

    public void Run()
    {
        if (Initialize())
        {
            Wait("Prepare to begin breathing", 5, true);
            while (DateTime.Now <= _endTime)
            {
                Wait($"Breathe in...", 5, true);
                Wait($"Breathe out...", 5, true);
            }

            endMessage();
        }
    }

}