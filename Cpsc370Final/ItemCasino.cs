namespace Cpsc370Final;

public class ItemCasino : ItemOneTimePurchase
{
    
    public ItemCasino()
    {
        Cost = 25;
        AlreadyOwns = false;
    }
    public void Buy()
    {
        base.Buy();
        Casino.hasCasino = true;
        Inventory.AddCasinoToInventory();
    } 
}