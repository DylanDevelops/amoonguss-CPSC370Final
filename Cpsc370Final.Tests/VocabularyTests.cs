namespace Cpsc370Final.Tests;

public class VocabularyTests
{
    [Theory]
    [InlineData("buy")]
    [InlineData("bet")]
    [InlineData("play")]
    [InlineData("show")]
    [InlineData("see")]
    public void TestIsVerb(string word)
    {
        Assert.True(Vocabulary.IsVerb(word));
    }
    
    [Theory]
    [InlineData("click")]
    [InlineData("quit")]
    [InlineData("casino")]
    [InlineData("rivals")]
    [InlineData("hit")]
    [InlineData("stay")]
    [InlineData("exit")]
    public void TestIsStandaloneVerb(string word)
    {
        Assert.True(Vocabulary.IsStandaloneVerb(word));
    }
    
    [Theory]
    [InlineData("casino")]
    [InlineData("rivals")]
    [InlineData("slots")]
    [InlineData("blackjack")]
    [InlineData("jon")]
    [InlineData("slingshot")]
    [InlineData("cloner")]
    public void TestIsNoun(string word)
    {
        Assert.True(Vocabulary.IsNoun(word));
    }
}