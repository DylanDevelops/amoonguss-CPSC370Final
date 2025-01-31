namespace Cpsc370Final;

public static class Help
{
    public static void HelpDump()
    {
        IO.WriteLine("In Sandie Clicker there are 4 game states");
        IO.WriteLine("Clicking, Shopping, Gambling, Rivaling");
        IO.WriteLine("Commands for Clicking GameState");
        IO.WriteLine("click : clicks sandies");
        IO.WriteLine("clicked : clicks sandies but you should only do this when forced to by teh random event");
        IO.WriteLine("c : clicks sandies but you can type less but requires the typeless upgrade");
        IO.WriteLine("quit : quits the game");
        IO.WriteLine("shop : switches to shopping gamestate");
        IO.WriteLine("casino : switches to gambling gamestate");
        IO.WriteLine("rivals : switches to rivaling gamestate");
        IO.WriteLine("see costume : lets you see the costumes of your sandies if you own any");
        IO.WriteLine("help : shows this info dump");
        IO.WriteLine("there is also a secret one word passcode to get 1 million sandies instantly");
        IO.WriteLine("Commands for Shopping GameState");
        IO.WriteLine("help : shows this info dump");
        IO.WriteLine("exit : switches back to clicking gamestate");
        IO.WriteLine("show prices : shows the prices of all things in the shop");
        IO.WriteLine("buy ______ : buy will buy the item typed after it if you have enough sandies to purchase it");
        IO.WriteLine("Commands for Gambling GameState");
        IO.WriteLine("help : shows this info dump");
        IO.WriteLine("bet __ : allows you to place a bet. Amount must be at least 10 and at most 1000. This is only required for blackjack and must be done befor eplaying blackjack");
        IO.WriteLine("play blackjack : will let you play blackjack if you have a bet placed");
        IO.WriteLine("play slots : will let you play slots if you have at least 10 sandies");
        IO.WriteLine("exit : switches back to clicking gamestate");
        IO.WriteLine("Commands for Rivaling GameState");
        IO.WriteLine("help : shows this info dump");
        IO.WriteLine("exit : switches back to clicking gamestate");
        IO.WriteLine("play support : runs a game of sandie rivals as support");
        IO.WriteLine("play tank : runs a game of sandie rivals as tank");
        IO.WriteLine("play dps : runs a game of sandie rivals as dps");

        
    }
}