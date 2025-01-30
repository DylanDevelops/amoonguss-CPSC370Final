namespace Cpsc370Final.Tests;

public class SandieBankTests
{
    [Fact]
    public void InitializeTest()
    {
        SandieBank.initialize();
        Assert.Equal(0, SandieBank.SandieCount);
    }

    [Fact]
    public void AddSandiesToBankTest()
    {
        SandieBank.initialize();
        SandieBank.addSandiesToBank(5);
        Assert.Equal(5, SandieBank.SandieCount);
    }

    [Fact]
    public void RemoveSandiesFromBankTest()
    {
        SandieBank.initialize();
        SandieBank.addSandiesToBank(20);
        SandieBank.removeSandiesFromBank(5);
        Assert.Equal(15, SandieBank.SandieCount);
    }
}