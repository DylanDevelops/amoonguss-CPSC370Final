namespace Cpsc370Final;

public static class Casino
{
    public static bool hasCasino = false;
    public static int bet = 0;

    public static void setBet(int amount)
    {
        bet += amount;
        SandieBank.removeSandiesFromBank(amount);
    }

    public static void Play(string gameName)
    {

        if (Blackjack.inBlackjack)
        {
            IO.Write("Already in Blackjack match");
        }
        else if (gameName.ToLower() == "slots")
        {
            Slots.StartGame();
        }
        else if (gameName.ToLower() == "blackjack")
        {
            if (bet < 10)
            {
                IO.Write("minimum bet of 10 must be made before playing blackjack");
            }
            else
            {
                Blackjack.StartGame();
            }
        }
    }
    

    public static void Win()
    {
        if (Blackjack.inBlackjack)
        {
            SandieBank.addSandiesToBank(2 * bet);
            Blackjack.inBlackjack = false;
            
        }
        bet = 0;
        Game.Play();
    }

    public static void Lose()
    {
        bet = 0;
        Blackjack.inBlackjack = false;
        Game.Play();
    }
    public static void Exit()
    {
        States.ChangeState(StateType.Clicking);
    }
}