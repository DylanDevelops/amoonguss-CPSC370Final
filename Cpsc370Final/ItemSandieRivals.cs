namespace Cpsc370Final;

public class ItemSandieRivals : ItemOneTimePurchase
{
    public ItemSandieRivals()
    {
        Cost = 30;
        AlreadyOwns = false;
    }
    public void Buy()
    {
        base.Buy();
        Rivals.hasRivals = true;
        Inventory.AddSandieRivalsToInventory();
    } 
}