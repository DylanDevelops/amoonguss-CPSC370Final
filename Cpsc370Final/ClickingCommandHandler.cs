namespace Cpsc370Final;

public class ClickingCommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap = new Dictionary<string, Action<Command>>()
    {
        {"click", Click},
        {"quit", Quit},
        {"shop", Shop},
        {"rivals", Rivals},
        {"casino", Casino}
    };
    
    public static void Handle(Command command)
    {
        if (commandMap.ContainsKey(command.Verb))
        {
            Action<Command> action = commandMap[command.Verb];
            action.Invoke(command);
        }
        else
        {
            IO.WriteLine("I don't understand that command.");
        }
    }

    private static void Click(Command command)
    {
        //whatever click does
        IO.Write("You clicked: +1");
    }

    private static void Quit(Command command)
    {
        Game.Quit();
    }
    
    private static void Shop(Command command)
    {
        //make it switch to shop game state
    }
    
    private static void Rivals(Command command)
    {
        //make it switch to rivals state
    }
    
    private static void Casino(Command command)
    {
        //make it switch to gambling state
    }
}