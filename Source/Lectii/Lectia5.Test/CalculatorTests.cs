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
        Assert.Equal(2, systemUnderTest.Divide(10, 5));
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        var systemUnderTest = new Calculator(_logFile);

        Assert.Throws<Exception>(() => systemUnderTest.Divide(1, 0));
    }

    [Fact]
    public void Multiply_ValidValues_ShouldReturnExpectedResult()
    {
        var systemUnderTest = new Calculator(_logFile);
        Assert.Equal(6, systemUnderTest.Multiply(2, 3));
        Assert.Equal(6, systemUnderTest.Multiply(3, 2));
        Assert.Equal(0, systemUnderTest.Multiply(0, 6));
        Assert.Equal(0, systemUnderTest.Multiply(10, 0));
    }
}