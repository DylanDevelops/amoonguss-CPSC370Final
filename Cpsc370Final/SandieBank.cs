namespace Cpsc370Final;

public static class SandieBank
{
    public static int SandieCount { get; private set; }

    public static void initialize()
    {
        SandieCount = 0;
    }

    public static void addSandiesToBank(int sandiesToAdd)
    {
        SandieCount += sandiesToAdd;
    }

    public static void removeSandiesFromBank(int sandiesToRemove)
    {
        SandieCount -= sandiesToRemove;
    }
    
    
}