namespace Cpsc370Final;

public static class PlayerClass
{
    public static int NumberOfSandies { get; private set; }
    
    public static int SandiesToAdd {get; private set;}

    public static int OwnedJons { get; private set;}
    

    public static void Click()
    {
        //Initialize SandiesToAdd
        SandiesToAdd = 1;
        
        //Adds per Upgrade
        SandiesToAdd += OwnedJons;
        
        
        //Added to total amount 
        NumberOfSandies += SandiesToAdd;
    }


}