namespace Cpsc370Final;

public class GamblingCommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap = new Dictionary<string, Action<Command>>()
    {
        {"bet", Bet},
        {"exit", Exit},
        {"raise", Raise},
        {"hit", Hit},
        {"fold", Fold},
        {"stay", Stay},
        {"check", Check},
        {"play", Play}
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

    private static void Check(Command command) //poker
    {
        //stay at current bet
    }
    private static void Fold(Command command) //poker
    {
        //lose the game
    }
    private static void Raise(Command command) //poker
    {
        Casino.raiseBet(int.Parse(command.Noun));
    }
    private static void Stay(Command command) //blackjack
    {
        Casino.Stay();
    }
    private static void Hit(Command command)//blackjack
    {
        Casino.Hit();
    }

    private static void Play(Command command)
    {
        Casino.Play(command.Noun);
    }
}