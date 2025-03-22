public class ListingActivity : Activity
{
    private Random _rng = new Random();

    List<string> _prompts;

    public ListingActivity(string name, string description, List<int> durationOptions, List<string> prompts)
    : base (name, description, durationOptions)
    {
        _prompts = prompts;
    }

    
    public void Run()
    {
        int randomNumber;
        int itemsEntered = 0;

        if(Initialize())
        {
            randomNumber = _rng.Next(_prompts.Count());

            Wait($"Prepare to write...\n\n{_prompts[randomNumber]}",5,true);
            Console.Clear();
            Console.WriteLine($"List as many things as you can.\n\n{_prompts[randomNumber]}:");

            while (DateTime.Now <= _endTime)
            {
                Console.Write(">");
                Console.ReadLine();
                itemsEntered += 1;
            }

            
            Console.Write($"You entered {itemsEntered}");
            Console.Read();
            endMessage();
        }
    }

}