namespace Lectia4;

public abstract class Being
{
    private bool _isAlive;
    public bool IsAlive
    {
        set
        { _isAlive = value; }
    }

    public Being()
    {
        IsAlive = true;
    }

    public abstract int GetMovementSpeed();
}
