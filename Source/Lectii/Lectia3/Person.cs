namespace Lectia3Gabi;

public class Person
{
    public virtual void Talk()
    {
        Console.WriteLine("Hello");
    }

    public virtual void Talk(string other)
    {
        Console.WriteLine($"Hello: {other}");
    }

    public virtual void Talk(int other)
    {
        Console.WriteLine($"Hello {other}");
    }
}
