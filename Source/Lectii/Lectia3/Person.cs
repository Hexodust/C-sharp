namespace Lectia3;

public class Person
{
    public virtual string GetTitle() // Allow children to change the implementation using keyword "virtual"
    {
        return "ordinary person";
    }
}
