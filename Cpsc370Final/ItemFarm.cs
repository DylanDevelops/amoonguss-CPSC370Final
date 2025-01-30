namespace Cpsc370Final;

public class ItemFarm : ItemSandiesPerClick
{

    public ItemFarm()
    {
        Cost = 20;
        SandiesPerClickIncrease = 4;
    }
    public void Buy()
    {
        base.Buy();
        Inventory.AddFarmsToInventory(1);
    } 
}