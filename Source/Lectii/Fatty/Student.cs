namespace Fatty;

public class Student : Person
{
    public Student Leader { get; set; }
    public Student(string name, string address, int age, char sex, string eyeColor, Student leader) : base(name, address, age, sex, eyeColor) //Constructorul Student apeleaza constructorul de baza ( constructorul Person)
    {
        Leader = leader;

        Console.WriteLine("Created a student");
    }
}