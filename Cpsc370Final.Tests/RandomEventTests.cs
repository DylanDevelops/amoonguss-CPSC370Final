namespace Cpsc370Final.Tests;
using Xunit;
using NUnit.Framework;


public class UnitTest1
{

    [Fact]
    public void testTaxesEvent(){
        testAmount = RandomEvent.taxesEvent(10);
        Assert.Equal(8, testAmount);
    }

    [Fact]
    public void testChocolateEvent(){
        testMethod = RandomEvent.chocolateEvent();
        Assert.That(true, testMethod);
    }

    [Fact]
    public void testTreatEvent(){
        testAmount = RandomEvent.treatEvent(10);
        Assert.Equal(12, testAmount);
    }

    [Fact]
    public void testWalkEvent(){
        testAmount = RandomEvent.walkEvent(10);
        Assert.Equal(12, testAmount);
    }

    [Fact]
    public void testRandomNumberGenerator(){
        randomNumber = RandomEvent.genRandomNumber();
        Assert.NotNull(randomNumber);
    }

    [Fact]
    public void testRandomEvent(){
        randomEvent = RandomEvent.getRandomEvent();
        Assert.NotEqual("Error", randomEvent);
    }
}