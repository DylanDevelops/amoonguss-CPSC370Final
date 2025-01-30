namespace Cpsc370Final;

public abstract class ItemOneTimePurchase : Item
{
    protected bool AlreadyOwns;
    
    public void Buy()
    {
        if (AlreadyOwns)
        {
            IO.WriteLine("You already own that");
            return;
        }
        AlreadyOwns = true;
        base.Buy();
    }

    public bool getOwnStatus()
    {
        return AlreadyOwns;
    }
}