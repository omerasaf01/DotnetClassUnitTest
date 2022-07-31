using TextService;

namespace TextService.Tests;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 1;
        int b = 2;

        int response = Calculator.Topla(a, b);

        Assert.Equal(response, 3);
    }
}