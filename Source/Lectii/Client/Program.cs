var program = new Lectia1.Program();
var age = 18;
var year = 1900;

Console.WriteLine(args);


program.Test1(age, year);
//program.Test2(age, year);

public class MyClass : Lectia1.Program
{
    public void MyFunc()
    {
        var age = 18;
        var year = 1900;
        Test5(age, year);
    }
}