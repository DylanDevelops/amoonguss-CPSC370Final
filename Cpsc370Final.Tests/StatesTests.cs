namespace Cpsc370Final.Tests;

public class StatesTests
{
    [Fact]
    public void TestGetCurrentState()
    {
        States.Initialize();
        Assert.Equal(StateType.Clicking, States.GetCurrentState());
    }
    
    [Fact]
    public void TestGetCurrentStateIsNotGambling()
    {
        States.Initialize();
        Assert.NotEqual(StateType.Gambling, States.GetCurrentState());
    }
    
    [Theory]
    [InlineData(StateType.Clicking)]
    [InlineData(StateType.Shopping)]
    [InlineData(StateType.Rivaling)]
    [InlineData(StateType.Gambling)]
    public void TestChangeState(StateType type)
    {
        States.Initialize();
        States.ChangeState(type);
        Assert.Equal(type, States.GetCurrentState());
    }
}