namespace Cpsc370Final;

public class ItemCostume : Item
{
    public void Buy()
    {
        base.Buy();
        Inventory.AddNextCostumeToSandie();
    } 
}