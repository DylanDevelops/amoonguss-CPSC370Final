﻿namespace Cpsc370Final;

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
        IO.Write("You clicked: +" + Player.SandiesPerClick);
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
}