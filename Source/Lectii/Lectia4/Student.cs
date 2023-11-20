namespace Lectia4;

internal class Student : Person, ITalkable
{
    public override int GetMovementSpeed()
    {
        return 7;
    }

    public override string GetTitle()
    {
        return "young man";
    }
}
