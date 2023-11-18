namespace Lectia3Gabi;

public class Student : Person
{
    public override void Talk()
    {
        base.Talk();
        Console.WriteLine("Hey yo!");
    }

    public override void Talk(string other)
    {
        Console.WriteLine($"Hey yo {other}?!");
    }

    public void Talk(List<string> others)
    {
        foreach (var other in others)
        {
            Console.WriteLine($"Hey yo {other}!!!");
        }
    }
}
