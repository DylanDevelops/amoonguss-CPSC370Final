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
            case "sandie rivals":
                SandieRivals.Buy();
                break;
            case "type less":
                TypeLess.Buy();
                break;
            case "costume":
                Costume.Buy();
                break;
        }
    }
}