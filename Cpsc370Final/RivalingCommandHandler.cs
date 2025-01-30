namespace Cpsc370Final;

public class RivalingCommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap = new Dictionary<string, Action<Command>>()
    {
        {"play", Play},
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


    private static void Play(Command command)
    {
        Rivals.StartGame(command.Noun);
    }
    
    private static void Exit(Command command)
    {
        States.ChangeState(StateType.Clicking);
    }
}