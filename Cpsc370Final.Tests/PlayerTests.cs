namespace Cpsc370Final.Tests;

public class PlayerTests
{
    [Fact]
    public void TestInitialize()
    {
        Player.Initialize();
        Assert.Equal(1, Player.SandiesPerClick);
    }
    
    [Fact]
    public void TestClick()
    {
        Player.Initialize();
        SandieBank.initialize();
        Player.Click();

        bool isGreater = SandieBank.SandieCount > 0;
        Assert.True(isGreater);
    }

    [Fact]
    public void TestUpdateSandiesPerClick()
    {
        Player.Initialize();
        Player.UpdateSandiesPerClick(5);
        Assert.Equal(6, Player.SandiesPerClick);
    }
}