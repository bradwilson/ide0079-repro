using Xunit;

public class Example
{
    [Fact]
#pragma warning disable xUnit1001 // Fact methods cannot have parameters
    public void Test1(int _)
#pragma warning restore xUnit1001 // Fact methods cannot have parameters
    { }
}
