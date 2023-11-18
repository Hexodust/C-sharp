namespace Lectia3Gabi;

public class Phd : Student
{
    public override void Talk()
    {
        Console.WriteLine("I am superior");
    }

    public override void Talk(string other)
    {
        Console.WriteLine($"I am better than {other}");
    }
}
