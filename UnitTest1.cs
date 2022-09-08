namespace TestUI;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double remain = 3532.50;
        Assert.Equal(remain, 3532.50);
    }
}