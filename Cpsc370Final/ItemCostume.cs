namespace Cpsc370Final;

public class ItemCostume : Item
{
    public ItemCostume()
    {
        Cost = 10;
    }
    public void Buy()
    {
        base.Buy();
        IO.WriteLine("You bought your sandies a new costume.");
        IO.WriteLine("you can type see costume to see description of  the new costume");
        Inventory.AddNextCostumeToSandie();
    } 
}