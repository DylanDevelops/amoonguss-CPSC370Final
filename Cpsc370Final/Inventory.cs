namespace Cpsc370Final;

public static class Inventory
{
    public static int NumberOfJons { get; private set; }
    public static int NumberOfSlingshots { get; private set; }
    public static int NumberOfCloners { get; private set; }
    public static int NumberOfFarms{ get; private set; }
    
    public static bool OwnsCasino { get; private set; }
    public static bool OwnsSandieRivals { get; private set; }
    public static bool OwnsTypeLess { get; private set; }
    
    public static int CostumeNumber { get; private set; }

    public static void Initialize()
    {
        NumberOfJons = 0;
        NumberOfSlingshots = 0;
        NumberOfCloners = 0;
        NumberOfFarms = 0;
        
        OwnsCasino = false;
        OwnsSandieRivals = false;
        OwnsTypeLess = false;
        
        CostumeNumber = 0;
    }

    public static void AddJonsToInventory(int numberOfJonsToAdd)
    {
        NumberOfJons += numberOfJonsToAdd;
    }

    public static void AddSlinghotsToInventory(int numberOfSlingshotsToAdd)
    {
        NumberOfSlingshots += numberOfSlingshotsToAdd;
    }

    public static void AddClonersToInventory(int numberOfClonersToAdd)
    {
        NumberOfCloners += numberOfClonersToAdd;
    }

    public static void AddFarmsToInventory(int numberOfFarmsToAdd)
    {
        NumberOfFarms += numberOfFarmsToAdd;
    }

    public static void AddCasinoToInventory()
    {
        OwnsCasino = true;
    }

    public static void AddSandieRivalsToInventory()
    {
        OwnsSandieRivals = true;
    }

    public static void AddTypeLessToInventory()
    {
        OwnsTypeLess = true;
    }

    public static void AddNextCostumeToSandie()
    {
        ++CostumeNumber;
    }
}