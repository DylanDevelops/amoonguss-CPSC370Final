namespace Cpsc370Final.Tests;
using Xunit;

public class RandomEventTests
{
    [Fact]
    public void TestTaxesEvent(){
        int testAmount = RandomEvent.TaxesEvent(10);
        Assert.Equal(8, testAmount);
    }

    [Fact]
    public void TestChocolateEvent(){
        int testMethod = RandomEvent.ChocolateEvent();
        Assert.Equal(0, testMethod);
    }

    [Fact]
    public void TestTreatEvent(){
        int testAmount = RandomEvent.TreatEvent(10);
        Assert.Equal(12, testAmount);
    }

    [Fact]
    public void TestWalkEvent(){
        int testAmount = RandomEvent.WalkEvent(10);
        Assert.Equal(12, testAmount);
    }

    [Fact]
    public void TestRandomNumberGenerator(){
        Assert.NotNull(RandomEvent.GenRandomNumber());
    }

    [Fact]
    public void TestRandomEvent(){
        int randomEvent = RandomEvent.GetRandomEvent();
        Assert.NotEqual(-1, randomEvent);
    }
}