namespace Cpsc370Final;

public class GamblingCommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap = new Dictionary<string, Action<Command>>()
    {
        {"bet", Bet},
        {"exit", Exit},
        {"play", Play},
        {"help", Help}
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
        Casino.setBet(int.Parse(command.Noun));
    }
    
    private static void Exit(Command command)
    {
        Casino.Exit();
    }

    private static void Play(Command command)
    {
        Casino.Play(command.Noun);
    }
    private static void Help(Command command)
    {
        Cpsc370Final.Help.HelpDump();
    }
}