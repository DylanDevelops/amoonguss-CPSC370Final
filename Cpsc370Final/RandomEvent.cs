namespace Cpsc370Final
using System;

class RandomEvent{

    static string getRandomEvent(){
        int randomEvent;
        int numSandies = "placeholder for method"
        int randomNumber = genRandomNumber();
        switch(randomNumber){
            case: 1
                randomEvent = taxesEvent(numSandies);
                break;
            case 2:
                randomEvent = longerWordEvent();
                break;
            case 3:
                (bool)randomEvent = chocolateEvent();
                break;
            case 4:
                randomEvent = treatEvent(numSandies);
                break;
            case 5:
                randomEvent = walkEvent(numSandies);
                break;
        }
        
        return randomEvent;
    }

    private static int taxesEvent(int numSandies){
        int taxedAmount = (double)numSandies * 0.8;
        return taxedAmount;
    }

    private static string longerWordEvent(){
        return " "
    }

    private static bool chocolateEvent(){
        return true;
    }

    private static int treatEvent(int numSandies){
        int boostedAmount = (double)numSandies * 1.2;
        return boostedAmount;

    }

    private static int walkEvent(int numSandies){
        int boostedAmount = (double)numSandies * 1.2;
        return boostedAmount;

    }

    private static int genRandomNumber(){
        Random rnd = new Random();
        int randomInteger = rnd.Next(1,5);
        return randomInteger;
    }











}