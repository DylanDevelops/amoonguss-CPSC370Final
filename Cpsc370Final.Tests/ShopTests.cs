namespace Cpsc370Final.Tests;

public class ShopTests
{
    [Theory]
    [InlineData("Jon")]
    [InlineData("Slingshot")]
    [InlineData("cloner")]
    [InlineData("farm")]
    [InlineData("casino")]
    [InlineData("rivals")]
    [InlineData("typeless")]
    [InlineData("costume")]
    public void TestBuyItemWhenCanAfford(string ItemName) //this test fails if isnt ran in debug unit test mode
    {
        States.ChangeState(StateType.Shopping);
        Inventory.Initialize();
        SandieBank.initialize();
        Player.Initialize();
        Shop Shop = new Shop();
        for (int i = 0; i <= 149; ++i)
        {
            Player.Click();
        }
        Shop.BuyItem(ItemName);

        int expectedFinalBal = 0;
        switch (ItemName.ToLower())
        {
            case "jon":
                expectedFinalBal = 150-5;
                break;
            case "slingshot":
                expectedFinalBal = 150-10;
                break;
            case "cloner":
                expectedFinalBal = 150-15;
                break;
            case "farm":
                expectedFinalBal = 150-20;
                break;
            case "casino":
                expectedFinalBal = 150-25;
                break;
            case "rivals":
                expectedFinalBal = 150 - 30;
                break;
            case "typeless":
                expectedFinalBal = 150 - 100;
                break;
            case "costume":
                expectedFinalBal = 150-10;
                break;
        }
        
        Assert.Equal(expectedFinalBal, SandieBank.SandieCount);
    }
}