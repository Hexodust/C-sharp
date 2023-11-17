namespace Skinny;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string EyeColor { get; set; }
    public Sex Sex { get; set; }

    public override string ToString()
    {
        return $"Name = {Name}, Age = {Age}, EyeColor = {EyeColor}, Sex = {Sex}";
    }
}