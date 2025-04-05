public class Menu(string header, List<string> options)
{
    private string _header = header;
    private List<string> _options = options;

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
/*|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

For running as a main menu:

bool run = true;
while(run)
{   
    switch(mainMenu.Run())
    {
        case 0:
            //option 1;
            break;
        case 1:
            //option 2;
            break;
        case 2:
            //option 3;
            break;
        case -1
            run = false;
            break;
    }
}

For running as an inner menu:
    Execute bool is returned to determine if the menu's selection actually does anything.
    If it does nothing, it simply returns to the containing main menu.

bool execute = true;
switch(menu.Run())
{
    case 0:
        //option 1;
        break;
    case 1:
        //option 2;
        break;
    case 2:
        //option 3;
        break;
    case -1:
        execute = false;
        break;            
}
return execute;

|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||*/
