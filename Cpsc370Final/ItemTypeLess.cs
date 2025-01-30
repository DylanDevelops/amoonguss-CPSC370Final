namespace Cpsc370Final;

public class ItemTypeLess : ItemOneTimePurchase
{
    public ItemTypeLess()
    {
        Cost = 100;
        AlreadyOwns = false;
    }
    public void Buy()
    {
        base.Buy();
        Inventory.AddTypeLessToInventory();
    } 
}