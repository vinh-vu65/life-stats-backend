namespace life_stats.Console.Tests;

public class UnitTest1
{
    private int Add(int x, int y) => x + y;

    [Fact]
    public void WhenGivenTwoNumbers_Add_ShouldReturnTheSumOfTheTwoNumbers()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void WhenGivenTwoNumbers_Add_ShouldNotReturnTheIncorrectSumOfTheTwoNumbers()
    {
        Assert.NotEqual(5, Add(2, 2));
    }
}
