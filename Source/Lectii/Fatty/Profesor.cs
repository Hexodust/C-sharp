using Fatty;

public class Profesor : Person
{
    public string Specializare { get; set; }

    public Profesor(string name, string address, int age, char sex, string eyeColor, string specializare) : base(name, address, age, sex, eyeColor)
    {
        Specializare = specializare;
    }
}