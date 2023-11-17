namespace Lectia3;

public class MyMaths
{
    private int _id = 0;
    public static int StaticId { get; private set; } = 0;

    public static int Floor(float number)
    {
        // Console.WriteLine(_id); // Non static field cannot be accessed from static function
        StaticId++;
        Console.WriteLine(StaticId);
        return 0; // Not the real implementation. It is just to demonstrate static functions
    }

    public static int Ceiling(float number)
    {
        StaticId++;
        Console.WriteLine(StaticId);
        return 0; // Not the real implementation. It is just to demonstrate static functions
    }

    public int GetMagicNumber()
    {
        return StaticId % 99 + _id; // Static field can be accessed even from non static function
    }

    public float GetMagicNumber(int id) // A function can be overloaded only if the parameters are different. The returned type does not matter
    {
        return StaticId % 99 + id;
    }

    public float GetMagicNumber(long id) // A function can be overloaded only if the parameters are different. The returned type does not matter
    {
        return StaticId % 99 + id;
    }

    public float GetMagicNumber(int id, int seed) // A function can be overloaded only if the parameters are different. The returned type does not matter
    {
        return seed % 99 + id;
    }
}
