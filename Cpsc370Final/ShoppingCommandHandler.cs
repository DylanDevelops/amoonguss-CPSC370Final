namespace Cpsc370Final;

public class ShoppingCommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap = new Dictionary<string, Action<Command>>()
    {
        {"buy", Buy},
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


    private static void Buy(Command command)
    {

    }

    private static void Exit(Command command)
    {
        States.ChangeState(StateType.Clicking);
    }
}