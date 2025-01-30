namespace Cpsc370Final;

public static class Casino
{
    public static bool inPoker = false;
    public static bool inBlackjack = false;
    
    public static int bet = 0;

    public static void setBet(int amount)
    {
        bet = amount;
        //remove amount from playerbank
    }

    public static void raiseBet(int amount)
    {
        bet += amount;
        //remove amount from playerbank
    }

    public static void Play(string gameName)
    {
        if(inPoker)
        {
            IO.Write("Already in Poker match");
        }
        else if (inBlackjack)
        {
            IO.Write("Already in Blackjack match");
        }
        else if (gameName.ToLower() == "poker")
        {
            //poker.StartGame();
        }
        else if (gameName.ToLower() == "blackjack")
        {
            Blackjack.StartGame();
        }
    }

    public static void Hit()
    {
        if (inBlackjack)
        {
            Blackjack.hit();
        }
    }
    public static void Stay()
    {
        if (inBlackjack)
        {
            Blackjack.stay();
        }
    }
    public static void Exit()
    {
        States.ChangeState(StateType.Clicking);
    }
}