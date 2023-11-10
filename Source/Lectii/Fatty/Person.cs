namespace Fatty;

public class Person
{
    private int _id;
    public string Name { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public char Sex { get; set; }
    public string EyeColor { get; set; }

    public Person(string name, string address, int age, char sex, string eyeColor)
    {
        Name = name;
        Address = address;
        Age = age;
        Sex = sex;
        EyeColor = eyeColor;

        Console.WriteLine("Created a Person");
    }
}