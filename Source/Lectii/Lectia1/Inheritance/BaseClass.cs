namespace Lectia1.Inheritance;

public class BaseClass
{
    public virtual string GetCurrentDate()
    {
        var date = DateTime.Now;
        return date.ToString();
    }
}
