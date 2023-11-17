public class Director : Profesor
{
    public string Birou { get; set; }

    public Director(string name, string address, int age, char sex, string eyeColor, string specializare, string birou) : base(name, address, age, sex, eyeColor, specializare)
    {
        Birou = birou;
    }
}