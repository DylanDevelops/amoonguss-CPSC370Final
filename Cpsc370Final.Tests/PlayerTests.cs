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
        Assert.Equal(1, SandieBank.SandieCount);
    }

    [Fact]
    public void TestUpdateSandiesPerClick()
    {
        Player.Initialize();
        Player.UpdateSandiesPerClick(5);
        Assert.Equal(6, Player.SandiesPerClick);
    }
}