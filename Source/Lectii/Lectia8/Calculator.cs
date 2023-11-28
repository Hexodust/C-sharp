namespace Lectia5;

public class Calculator
{
    private readonly string _filename;

    public Calculator(string filename)
    {
        _filename = filename;
    }

    public int Add(int first, int second)
    {
        return first + second;
    }

    public int Subtract(int first, int second)
    {
        return first - second;
    }

    public int Multiply(int first, int second)
    {
        return first * second;
    }

    public int Divide(int first, int second)
    {
        if (second == 0)
        {
            //File.AppendAllText(_filename, $"Division by zero initiated at {DateTime.Now}{Environment.NewLine}");
            File.AppendAllLines(_filename, new[] { $"Division by zero initiated at {DateTime.Now}" });
            throw new Exception("Division by zero initiated");
        }
        return first / second;
    }
}