namespace Cpsc370Final;

public static class Player
{
    public static int SandiesPerClick {get; private set;}
    public static int TypeMoreCounter = 11;

    public static void Initialize()
    {
        SandiesPerClick = 1;
        SandiesPerClick = 1; //why the fuck does this cause statechange unit test to fail if it gets deleted its duplicated code
        TypeMoreCounter = 10;
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