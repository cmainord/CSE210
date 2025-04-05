public class Goal
{
    private string _name;
    private int _pointValue;
    private string _description;
    private bool _completed = false;

    public Goal()
    {
        Create();
    }

    public virtual void Create()
    {
        Console.Write("Enter the name of your goal: ");
        _name = Console.ReadLine();

        Console.Write("Enter a point value for your goal: ");
        _pointValue = int.Parse(Console.ReadLine());

        Console.Write("Enter a brief description of your goal: ");
        _description = Console.ReadLine();
    }

    public void Display()
    {
        Console.Write($"[{GetCompletionMark()}] {_name}");
    }

    public string GetCompletionMark()
    {
        if(_completed)
        {
            return "x";
        }
        else
        {
            return " ";
        }

    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }


}