using Lectia4;

ITalkable talkable1 = new Person();

Being being1 = new Person();
Being being2 = new Student();
Being being3 = new Plant();


Person person1 = new Person();
Person person2 = new Student();
Student student3 = new Student();
//Student student3 = (Student)new Person(); // Will throw exception cast invalid

Console.WriteLine(person1.GetTitle());
Console.WriteLine(person2.GetTitle());
Console.WriteLine(being1.GetMovementSpeed());

Console.WriteLine(((Person)being1).GetTitle());

Console.WriteLine(((Person)being2).GetTitle());
Console.WriteLine(((Student)being2).GetTitle());

Console.ReadKey();
