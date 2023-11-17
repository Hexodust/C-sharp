using Lectia3;

var maths = new MyMaths();


var myFloat = 2.4f;
var myFloor = MyMaths.Floor(myFloat);
var myCeiling = MyMaths.Ceiling(myFloat);

Console.WriteLine(myFloor);
Console.WriteLine(myCeiling);

Console.WriteLine();
Console.WriteLine(maths);

Console.WriteLine(MyMaths.StaticId);
Console.WriteLine(maths.GetMagicNumber());

Console.WriteLine("Start creating teachers");

var person = new Person();
Console.WriteLine(person.GetTitle());

var teacher = new Teacher();
Console.WriteLine(teacher.GetTitle());

var smartTeacher = new PhysicsTeacher();
Console.WriteLine(smartTeacher.GetTitle());

Console.ReadKey();