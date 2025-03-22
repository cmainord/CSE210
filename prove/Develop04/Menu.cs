public class Menu
{
    private string _header;
    private List<string> _options;

    public Menu(string header, List<string> options)
    {
        _header = header;
        _options = options;
    }

    public int Run(int selectedOption = 0)
    {
        bool run = true;
        while(run)
        {
            Console.Clear();
            Console.WriteLine($"{_header}:");

            for(int i = 0; i < _options.Count; i++)
            {
                if(selectedOption == i)
                {
                    Console.WriteLine($"     ->\t{_options[i]} <-");
                }
                else
                {
                    Console.WriteLine($"    \t{_options[i]}");
                }
            }

            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (selectedOption < _options.Count - 1)
                    {
                        selectedOption += 1;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (selectedOption > 0)
                    {
                        selectedOption -= 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    run = false;
                    break;
                case ConsoleKey.Escape:
                    selectedOption = -1;
                    run = false;
                    break;
            }
        }
        return selectedOption;
    }
}


/*
public class MainMenu : Menu
{
    public MainMenu(string header, List<string> options)
    : base (header, options)
    {

    }
}
*/
