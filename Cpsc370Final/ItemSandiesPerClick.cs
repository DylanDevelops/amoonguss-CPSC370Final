namespace Cpsc370Final;

public abstract class ItemSandiesPerClick : Item
{
    protected int SandiesPerClickIncrease;
    
    public void Buy()
    {
        base.Buy();
        Player.UpdateSandiesPerClick(SandiesPerClickIncrease);
    }
}