public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    List<int> _durationOptions;
    protected bool _timerSet;
    protected DateTime _endTime;

    public Activity(string name, string description, List<int> durationOptions)
    {
        _name = name;
        _description = description;
        _durationOptions = durationOptions;
        _timerSet = false;

    }

    protected bool Initialize(bool setTimer = true)
    {
        
        Console.WriteLine($"{_name} \n\n{_description}\n");
        bool execute = SetDuration();
        if(setTimer)
        {
            SetTimer();
        }

        return execute;
    }

    public bool SetDuration()
    {
        Console.Clear();

        Menu durationMenu = new Menu($"{_name} -- Choose a Duration", [$"{_durationOptions[0]}", $"{_durationOptions[1]}", $"{_durationOptions[2]}"]);

        bool execute = true;
        switch(durationMenu.Run())
        {
            case 0:
                _duration = _durationOptions[0];
                break;
            case 1:
                _duration = _durationOptions[1];
                break;
            case 2:
                _duration = _durationOptions[2];
                break;
            case -1:
                execute = false;
                break;            
        }
        return execute;
    }

    protected void SetTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
        _timerSet = true;
    }

    //
    //THIS IS NOT WORKING PROPERLY
    //The counter is counting seconds slower than actual seconds
    //
    public void Wait(string message, int waitTime, bool showTimer = false, bool allowInput = false)
    {
        //Animation waitAnimation = new Animation(["|    ", ".|   ", "..|  ", "...| ", "    |", "   |.", "  |..", " |...",]);
        Animation waitAnimation = new Animation(["|", "/", "-", "\\"]);
        //Animation timerDisplay = new Animation(["5","4","3","2","1"], 1000);
        
        Animation timerDisplay = new Animation([$"{waitTime}"],1000);
        for(int i = waitTime-1; i > 0; i = i - 1)
        {
            timerDisplay.AddStates($"{i}");
        }
        

        DateTime endTime = DateTime.Now.AddSeconds(waitTime);

        while (DateTime.Now <= endTime)
        {
            
            Console.Clear();
            
            if (showTimer)
            {
                Console.WriteLine($"{waitAnimation.Display()} {timerDisplay.Display()} {message}");
            }
            else
            {
                Console.WriteLine($"{waitAnimation.Display()} {message}");
            }
            Thread.Sleep(200);            
        }
    }

    protected void endMessage()
    {
        Console.Clear();
        Console.Write("Done. Good Job.");
        Console.ReadLine();
    }
}