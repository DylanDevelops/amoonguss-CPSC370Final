namespace Cpsc370Final.Tests;

public class InventoryTests
{
    [Fact]
    public void InventoryInitializeTest()
    {
        Inventory.Initialize();
        Assert.Equal(0, Inventory.NumberOfJons);
        Assert.Equal(0, Inventory.NumberOfSlingshots);
        Assert.Equal(0, Inventory.NumberOfCloners);
        Assert.Equal(0, Inventory.NumberOfFarms);
        Assert.False(Inventory.OwnsCasino);
        Assert.False(Inventory.OwnsSandieRivals);
        Assert.False(Inventory.OwnsTypeLess);
        Assert.Equal(0, Inventory.CostumeNumber);
    }

    [Fact]
    public void TestAddJonsToInventory()
    {
        Inventory.Initialize();
        Inventory.AddJonsToInventory(5);
        Assert.Equal(5, Inventory.NumberOfJons);
    }

    [Fact]
    public void TestAddSlingshotsToInventory()
    {
        Inventory.Initialize();
        Inventory.AddSlinghotsToInventory(5);
        Assert.Equal(5, Inventory.NumberOfSlingshots);
    }

    [Fact]
    public void TestAddClonersToInventory()
    {
        Inventory.Initialize();
        Inventory.AddClonersToInventory(5);
        Assert.Equal(5, Inventory.NumberOfCloners);
    }

    [Fact]
    public void TestAddFarmsToInventory()
    {
        Inventory.Initialize();
        Inventory.AddFarmsToInventory(5);
        Assert.Equal(5, Inventory.NumberOfFarms);
    }

    [Fact]
    public void TestAddCasinoToInventory()
    {
        Inventory.Initialize();
        Inventory.AddCasinoToInventory();
        Assert.True(Inventory.OwnsCasino);
    }

    [Fact]
    public void TestAddSandieRivalsToInventory()
    {
        Inventory.Initialize();
        Inventory.AddSandieRivalsToInventory();
        Assert.True(Inventory.OwnsSandieRivals);
    }

    [Fact]
    public void TestAddTypeLessToInventory()
    {
        Inventory.Initialize();
        Inventory.AddTypeLessToInventory();
        Assert.True(Inventory.OwnsTypeLess);
    }

    [Fact]
    public void TestAddNextCostumeToInventory()
    {
        Inventory.Initialize();
        Inventory.AddNextCostumeToSandie();
        Assert.Equal(1, Inventory.CostumeNumber);
    }
}