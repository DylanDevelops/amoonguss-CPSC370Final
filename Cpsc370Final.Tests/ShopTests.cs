namespace Cpsc370Final.Tests;

public class ShopTests
{
    [Theory]
    [InlineData("Jon")]
    [InlineData("Slingshot")]
    [InlineData("cloner")]
    [InlineData("farm")]
    [InlineData("casino")]
    [InlineData("sandie rivaLs")]
    [InlineData("type less")]
    [InlineData("costume")]
    public void TestBuyItemWhenCanAfford(string ItemName)
    {
        Player.Initialize();
        Shop Shop = new Shop();
        for (int i = 0; i <= 150; ++i)
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
            case "sandie rivals":
                expectedFinalBal = 150-30;
                break;
            case "type less":
                expectedFinalBal = 150-100;
                break;
            case "costume":
                expectedFinalBal = 150-1;
                break;
        }
        
        Assert.Equal(expectedFinalBal, SandieBank.SandieCount);
    }
}