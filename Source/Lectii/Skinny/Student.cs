namespace Skinny;

public class Student : Person
{
    public Student Leader { get; set; }
    public List<TeachingClass> Classes { get; set; } = new List<TeachingClass>();
}
