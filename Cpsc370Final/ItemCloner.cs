namespace Cpsc370Final;

public class ItemCloner : ItemSandiesPerClick
{
    public ItemCloner()
    {
        Cost = 15;
        SandiesPerClickIncrease = 3;
    }
    public void Buy()
    {
        base.Buy();
        Inventory.AddClonersToInventory(1);
    } 
}