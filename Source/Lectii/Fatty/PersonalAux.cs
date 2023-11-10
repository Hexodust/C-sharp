using Fatty;

public class PersonalAux : Person
{
    public string Zona { get; set; }

    public PersonalAux(string name, string address, int age, char sex, string eyeColor, string zona) : base(name, address, age, sex, eyeColor)
    {
        Zona = zona;
    }
}