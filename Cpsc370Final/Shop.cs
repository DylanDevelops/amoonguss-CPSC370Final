namespace Cpsc370Final;

public class Shop
{
    private ItemJon Jon;
    private ItemSlingshot Slingshot;
    private ItemCloner Cloner;
    private ItemFarm Farm;
    private ItemCasino Casino;
    private ItemSandieRivals SandieRivals;
    private ItemTypeLess TypeLess;
    private ItemCostume Costume;
    
    public Shop()
    {
        Jon = new ItemJon();
        Slingshot = new ItemSlingshot();
        Cloner = new ItemCloner();
        Farm = new ItemFarm();
        Casino = new ItemCasino();
        SandieRivals = new ItemSandieRivals();
        TypeLess = new ItemTypeLess();
        Costume = new ItemCostume();
    }

    public void BuyItem(string itemTypeString)
    {
        switch (itemTypeString.ToLower())
        {
            case "jon":
                Jon.Buy();
                break;
            case "slingshot":
                Slingshot.Buy();
                break;
            case "cloner":
                Cloner.Buy();
                break;
            case "farm":
                Farm.Buy();
                break;
            case "casino":
                Casino.Buy();
                break;
            case "rivals":
                SandieRivals.Buy();
                break;
            case "typeless":
                TypeLess.Buy();
                break;
            case "costume":
                if (Inventory.CostumeNumber < 10)
                {
                    Costume.Buy(); 
                }
                break;
        }
    }

    public void DisplayPrices()
    {
        IO.WriteLine($"~ jon: $" + Jon.getCurrentCost());
        IO.WriteLine($"~ slingshot: $" + Slingshot.getCurrentCost());
        IO.WriteLine($"~ cloner: $" + Cloner.getCurrentCost());
        IO.WriteLine($"~ farm: $" + Farm.getCurrentCost());
        if (Cpsc370Final.Casino.hasCasino)
        {
            IO.WriteLine($"~ casino: Purchased");
        }
        else
        {
            IO.WriteLine($"~ casino: $" + Casino.getCurrentCost());
        }
        if (Cpsc370Final.Rivals.hasRivals)
        {
            IO.WriteLine($"~ rivals: Purchased");
        }
        else
        {
            IO.WriteLine($"~ rivals: " + SandieRivals.getCurrentCost());
        }
        if (TypeLess.getOwnStatus())
        {
            IO.WriteLine($"~ typeless: Purchased");
        }
        else
        {
            IO.WriteLine($"~ typeless: " + TypeLess.getCurrentCost());
        }

        if (Inventory.CostumeNumber == 10)
        {
            IO.WriteLine($"~ costume: Purchased");
        }
        else
        {
            IO.WriteLine($"~ costume: " + Costume.getCurrentCost());
        }
    }
}