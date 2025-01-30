namespace Cpsc370Final;

public class Slots
{
    public static void StartGame()
    {
        SandieBank.removeSandiesFromBank(10);
        IO.WriteLine("You pull down on the lever and the slots begin to spin");
        
        Random rnd = new Random();
        int randomResult = rnd.Next(1,31);
        if (randomResult == 28)
        {
            IO.WriteLine("You got the jackpot and win 1000 sandies");
            SandieBank.addSandiesToBank(1000);
            Casino.Win();
        }
        else if (randomResult == 29 || randomResult == 3 || randomResult == 17 )
        {
            SandieBank.addSandiesToBank(50);
            IO.WriteLine("You got 3 cherries and win 50 sandies");
            Casino.Win();
        }
        else if (randomResult == 20 || randomResult == 19 || randomResult == 12)
        {
            IO.WriteLine("You got the bar and win 10 sandies");
            SandieBank.addSandiesToBank(10);
            Casino.Win();
        }
        else
        {
            IO.WriteLine("You got nothing");
            Casino.Lose();
        }
        
    }
}