namespace Cpsc370Final;

public static class PlayerClass
{
    public int NumberOfSandies { get; private set; }
    
    public int SandiesToAdd {get; private set;}

    public int OwnedJons { get; private set;}
    

    public void Click()
    {
        //Initialize SandiesToAdd
        SandiesToAdd = 1;
        
        //Adds per Upgrade
        SandiesToAdd += OwnedJons;
        
        
        //Added to total amount 
        NumberOfSandies += SandiesToAdd;
    }


}