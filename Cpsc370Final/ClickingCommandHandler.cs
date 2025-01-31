namespace Cpsc370Final;

public class ClickingCommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap = new Dictionary<string, Action<Command>>()
    {
        {"click", Click},
        {"quit", Quit},
        {"shop", Shop},
        {"rivals", Rivals},
        {"casino", Casino},
        {"c", Click},
        {"see", See},
        {"clicked", Click},
        {"tsivkovski", SecretPhrase}
        
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
        if (command.Verb == "clicked" && Player.TypeMoreCounter < 10)
        {
            Player.TypeMoreCounter += 1;
        }
        else if (command.Verb == "c" && !Inventory.OwnsTypeLess)
        {
            IO.WriteLine("You do not own typeless and must type out click completely.");
        }
        IO.WriteLine("You clicked: +" + Player.SandiesPerClick);
        Player.Click();
    }

    private static void Quit(Command command)
    {
        Game.Quit();
    }
    
    private static void Shop(Command command)
    {
        IO.WriteLine("You are entering the shop!");
        States.ChangeState(StateType.Shopping);
            IO.WriteLine("      Shop        ");
            IO.WriteLine("type show prices to see prices");
    }
    
    private static void Rivals(Command command)
    {
        if (Cpsc370Final.Rivals.hasRivals)
        {
            IO.WriteLine("You are entering sandie rivals!");
            IO.WriteLine("To play sandie rivals type play followed by any of the 3 classes");
            IO.WriteLine("dps, support, or tank");
            IO.WriteLine("Example: play tank");
            States.ChangeState(StateType.Rivaling);
        }
        else
        {
            IO.WriteLine("You don't have access to sandie rivals!");
        }
    }
    
    private static void Casino(Command command)
    {
        if (Cpsc370Final.Casino.hasCasino)
        {
            IO.WriteLine("You are entering the casino!");
            IO.WriteLine("You can play blackjack");
            IO.WriteLine("Type play blackjack");
            IO.WriteLine("you must bet before playing blackjack by typing bet (amount)");
            IO.WriteLine("minimum bet is 10");
            IO.WriteLine("You can also play slots");
            IO.WriteLine("Type play slots");
            IO.WriteLine("It costs 10 to play slots");
        
            States.ChangeState(StateType.Gambling);
        }
        else
        {
            IO.WriteLine("You don't have access to casino!");
        }
        
    }

    private static void See(Command command)
    {
        if (command.Noun == "costume")
        {
            Costume.showCostume();
        }
        else
        {
            IO.WriteLine("Invalid Noun");
        }
    }

    private static void SecretPhrase(Command command)
    {
        IO.WriteLine("You entered the secret phrase and get 1 million sandies");
        SandieBank.addSandiesToBank(1000000);
    }
}