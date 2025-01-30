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
                //randomEvent = longerWordEvent();
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
        double taxedAmount = numSandies * 0.8;
        return (int)taxedAmount;
    }

    public static string LongerWordEvent()
    {
        return " ";
    }

    public static int ChocolateEvent(){
        return 0;
    }

    public static int TreatEvent(int numSandies){
        double boostedAmount = numSandies * 1.2;
        return (int)boostedAmount;

    }

    public static int WalkEvent(int numSandies){
        double boostedAmount = numSandies * 1.2;
        return (int)boostedAmount;

    }

    public static int GenRandomNumber(){
        Random rnd = new Random();
        int randomInteger = rnd.Next(1,5);
        return randomInteger;
    }



}