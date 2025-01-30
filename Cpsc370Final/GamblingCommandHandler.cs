namespace Cpsc370Final;

public class GamblingCommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap = new Dictionary<string, Action<Command>>()
    {
        {"bet", Bet},
        {"exit", Exit}
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


    private static void Bet(Command command)
    {
        //whatever bet does
    }
    
    private static void Exit(Command command)
    {
        //exit current game state and go back to clicking game state
    }
}