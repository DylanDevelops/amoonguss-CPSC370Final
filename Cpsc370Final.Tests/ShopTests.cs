namespace Cpsc370Final.Tests;

public class ShopTests
{
    [Fact]
    public void TestInstantiate()
    {
        Shop.Initialize();
        Assert.Equal(10, Shop.JonCost);
        Assert.Equal(20, Shop.SlingshotCost);
        Assert.Equal(30, Shop.ClonerCost);
        Assert.Equal(40, Shop.FarmCost);
        Assert.Equal(25, Shop.CasinoCost);
        Assert.Equal(50, Shop.SandieRivalsCost);
        Assert.Equal(100, Shop.TypeLessCost);
        Assert.Equal(5, Shop.CostumeCost);
        Assert.Equal(1, Shop.JonSandiesPerTurnIncrease);
        Assert.Equal(3, Shop.SlingshotSandiesPerTurnIncrease);
        Assert.Equal(5, Shop.ClonerSandiesPerTurnIncrease);
        Assert.Equal(10, Shop.FarmSandiesPerTurnIncrease);
    }

    [Theory]
    [InlineData("Jon")]
    [InlineData("Slingshot")]
    [InlineData("cloner")]
    [InlineData("farm")]
    [InlineData("casino")]
    [InlineData("sandie rivaLs")]
    [InlineData("type less")]
    [InlineData("costume")]
    public void TestBuyItemWhenCanAffort(string itemName)
    {
        Player.Initialize();
        for (int i = 0; i <= 150; ++i)
        {
            Player.Click();
        }
        Shop.BuyItem(itemName);
    }
}