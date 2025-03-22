public class ReflectionActivity : Activity
{
    Random rng = new Random();

    List<string> _initialPrompts;
    List<string> _followingPrompts;

    public ReflectionActivity(string name, string description, List<int> durationOptions, List<string> initalPrompts, List<string> followingPrompts)
    : base (name, description, durationOptions)
    {
        _initialPrompts = initalPrompts;
        _followingPrompts = followingPrompts;
    }

    
    public void Run()
    {
        if(Initialize(false))
        {
            int randomNumber;
            
            randomNumber = rng.Next(_initialPrompts.Count());
            Console.Clear();
            Console.Write($"{_initialPrompts[randomNumber]}\n\nThen, press enter to begin...");
            Console.ReadLine();
            
            SetTimer();
            while (DateTime.Now <= _endTime)
            {
                randomNumber = rng.Next(_followingPrompts.Count());
                Wait(_followingPrompts[randomNumber], 20, true);
            }

            endMessage();
        }
    }

}