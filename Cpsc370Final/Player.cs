namespace Cpsc370Final;

public static class Player
{
    public static int SandiesPerClick {get; private set;}

    public static void Initialize()
    {
        SandiesPerClick = 10;
    }

    public static void Click()
    {
        SandieBank.addSandiesToBank(SandiesPerClick);
    }

    public static void UpdateSandiesPerClick(int sandiesPerClickToAdd)
    {
        SandiesPerClick += sandiesPerClickToAdd;
    }
}