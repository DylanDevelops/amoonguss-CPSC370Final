namespace Cpsc370Final;

public class ItemSlingshot : ItemSandiesPerClick
{
    public ItemSlingshot()
    {
        Cost = 10;
        SandiesPerClickIncrease = 2;
    }
    public void Buy()
    {
        base.Buy();
        Inventory.AddSlinghotsToInventory(1);
    } 
}