namespace Cpsc370Final.Tests;

public class GameTests
{
    [Fact]
    public void TestPlay()
    {
        // This doesn't work yet :)
        var input = new StringReader("quit");
        Console.SetIn(input);
        Game.Play();

        Assert.False(Game.isPlaying);
    }
}