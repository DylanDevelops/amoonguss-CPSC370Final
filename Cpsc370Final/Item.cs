namespace Cpsc370Final;

public abstract class Item
{
    protected int Cost;
    
    protected void Buy()
    {
        if (CantAfford())
        {
            IO.WriteLine("You can't afford it brokie");
            return;
        }
        IO.WriteLine("Purchase Complete!");
        SandieBank.removeSandiesFromBank(Cost);
        ++Cost;
    }
    
    protected bool CantAfford()
    {
        if (SandieBank.SandieCount < Cost)
        {
            return true;
        }
        return false;
    }
    
    public int getCurrentCost()
    {
        return Cost;
    }
}