namespace Cpsc370Final;

public class ItemJon : ItemSandiesPerClick
{
    public ItemJon()
    {
        Cost = 5;
        SandiesPerClickIncrease = 1;
    }
    public void Buy()
    {
        base.Buy();
        Inventory.AddJonsToInventory(1);
    }
    
}