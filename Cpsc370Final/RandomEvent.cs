namespace Cpsc370Final;
using System;

public static class RandomEvent{

    public static int GetRandomEvent()
    {
        int randomEvent = 0;
        int numSandies = SandieBank.SandieCount;
        int randomNumber = GenRandomNumber();
        switch(randomNumber){
            case 1:
                randomEvent = TaxesEvent(numSandies);
                break;
            case 2:
                randomEvent = LongerWordEvent();
                break;
            case 3:
                randomEvent = ChocolateEvent();
                break;
            case 4:
                randomEvent = TreatEvent(numSandies);
                break;
            case 5:
                randomEvent = WalkEvent(numSandies);
                break;
            case 6:
                randomEvent = -1;                
                break;
        }
        
        return randomEvent;
    }

    public static int TaxesEvent(int numSandies){
        IO.WriteLine("The IRS taxes some of your sandies.");
        double taxedAmount = numSandies * 0.8;
        SandieBank.removeSandiesFromBank(numSandies - (int)taxedAmount);
        return (int)taxedAmount;
    }

    public static int LongerWordEvent()
    {
        IO.WriteLine("You now have to write clicked instead of click to click for the next 10 inputs");
        Player.TypeMoreCounter = 0;
        return 0;
    }

    public static int ChocolateEvent(){
        IO.WriteLine("Sandie ate some choclate.");
        IO.WriteLine("Game Over");
        Game.Quit();
        return 0;
    }

    public static int TreatEvent(int numSandies){
        IO.WriteLine("You use some dog treats to attract some more sandies");
        double boostedAmount = numSandies * 1.2;
        SandieBank.addSandiesToBank((int)boostedAmount - numSandies);
        return (int)boostedAmount;

    }

    public static int WalkEvent(int numSandies){
        IO.WriteLine("You go on a walk with your sandies and end up with more then you originally had");
        double boostedAmount = numSandies * 1.2;
        SandieBank.addSandiesToBank((int)boostedAmount - numSandies);
        return (int)boostedAmount;

    }

    public static int GenRandomNumber(){
        Random rnd = new Random();
        int randomInteger = rnd.Next(1,6);
        return randomInteger;
    }



}