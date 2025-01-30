namespace Cpsc370Final;

public static class Shop
{
    public static int JonCost { get; private set; }
    public static int SlingshotCost {get; private set;}
    public static int ClonerCost { get; private set; }
    public static int FarmCost { get; private set; }
    public static int CasinoCost { get; private set; }
    public static int SandieRivalsCost { get; private set; }
    public static int TypeLessCost { get; private set; }
    public static int CostumeCost { get; private set; }
    
    public static int JonSandiesPerTurnIncrease { get; private set;  }
    public static int SlingshotSandiesPerTurnIncrease { get; private set; }
    public static int ClonerSandiesPerTurnIncrease { get; private set; }
    public static int FarmSandiesPerTurnIncrease { get; private set; }
    
    
    public static void Initialize()
    {
        JonCost = 10;
        SlingshotCost = 20;
        ClonerCost = 30;
        FarmCost = 40;
        CasinoCost = 25;
        SandieRivalsCost = 50;
        TypeLessCost = 100;
        CostumeCost = 5;

        JonSandiesPerTurnIncrease = 1;
        SlingshotSandiesPerTurnIncrease = 3;
        ClonerSandiesPerTurnIncrease = 5;
        FarmSandiesPerTurnIncrease = 10;
    }

    public static void BuyItem(string itemTypeString)
    {
        switch (itemTypeString.ToLower())
        {
            case "jon":
                Buy(ItemType.Jon, JonCost, JonSandiesPerTurnIncrease);
                ++JonCost;
                Inventory.AddJonsToInventory(1);
                break;
            case "slingshot":
                Buy(ItemType.SandieSlingshot, SlingshotCost, SlingshotSandiesPerTurnIncrease);
                ++SlingshotCost;
                Inventory.AddSlinghotsToInventory(1);
                break;
            case "cloner":
                Buy(ItemType.SandieCloner, ClonerCost, ClonerSandiesPerTurnIncrease);
                ++ClonerCost;
                Inventory.AddClonersToInventory(1);
                break;
            case "farm":
                Buy(ItemType.SandieFarm, FarmCost, FarmSandiesPerTurnIncrease);
                ++FarmCost;
                Inventory.AddFarmsToInventory(1);
                break;
            case "casino":
                Buy(ItemType.Casino, CasinoCost, -1);
                Inventory.AddCasinoToInventory();
                break;
            case "sandie rivals":
                Buy(ItemType.SandieRivals, SandieRivalsCost, -1);
                Inventory.AddSandieRivalsToInventory();
                break;
            case "type less":
                Buy(ItemType.TypeLess, TypeLessCost, -1);
                Inventory.AddTypeLessToInventory();
                break;
            case "costume":
                Buy(ItemType.Costume, CostumeCost, -1);
                Inventory.AddNextCostumeToSandie();
                break;
        }
    }

    private static void Buy(ItemType itemType, int cost, int SandiesPerTurnIncrease)
    {
        if (Inventory.OwnsCasino && itemType == ItemType.Casino ||
            Inventory.OwnsSandieRivals && itemType == ItemType.SandieRivals ||
            Inventory.OwnsTypeLess && itemType == ItemType.TypeLess)
        {
            IO.WriteLine("You already own that");
            return;
        }
        if (CantAfford(cost))
        {
            IO.WriteLine("You can't afford it brokie");
            return;
        }
        IO.WriteLine("Purchase Complete!");
        SandieBank.removeSandiesFromBank(cost);
        if (SandiesPerTurnIncrease != -1)
        {
            Player.UpdateSandiesPerClick(SandiesPerTurnIncrease);
        }
    }
    
    private static bool CantAfford(int cost)
    {
        if (SandieBank.SandieCount < cost)
        {
            return true;
        }

        return false;
    }
}