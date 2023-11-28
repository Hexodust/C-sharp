namespace Lectia5.Test;

public class CalculatorTests
{
    private const string _logFile = "logs.txt";

    [Fact]
    public void Add_ValidValues_ShouldReturnExpectedResult()
    {
        var systemUnderTest = new Calculator(_logFile);

        Assert.NotNull(systemUnderTest);
        Assert.Equal(10, systemUnderTest.Add(2, 9));
        Assert.Equal(10, systemUnderTest.Add(1, 9));
    }

    [Fact]
    public void Subtract_ValidValues_ShouldReturnExpectedResult()
    {
        var systemUnderTest = new Calculator(_logFile);

        Assert.NotNull(systemUnderTest);
        Assert.Equal(5, systemUnderTest.Subtract(15, 10));
    }

    [Fact]
    public void Divide_ValidValues_ShouldReturnExpectedResult()
    {
        var systemUnderTest = new Calculator(_logFile);

        Assert.NotNull(systemUnderTest);
        Assert.Equal(1, systemUnderTest.Divide(1, 0));
    }

    [Fact]
    public void Multiply_ValidValues_ShouldReturnExpectedResult() { }
}