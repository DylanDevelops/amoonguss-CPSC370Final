namespace Cpsc370Final.Tests;

public class PlayerClassTests
{
    [Fact]
    public void ClickTest()
    {
        PlayerClass.Click();
        Assert.Equal(1, PlayerClass.Click());
    }
}