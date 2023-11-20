namespace Lectia4;

public class Person : Being, ITalkable
{
    public override int GetMovementSpeed()
    {
        return 5;
    }

    public virtual string GetTitle()
    {
        return "nothing special";
    }

    public void Talk()
    {
        Console.WriteLine("I am a person");
    }
}
