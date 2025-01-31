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
        IO.WriteLine("You now only have to type c to click");
        Inventory.AddTypeLessToInventory();
    } 
}