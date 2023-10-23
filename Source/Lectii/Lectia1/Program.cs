using Lectia1.CustomTypes;

namespace Lectia1;

public class Program
{
    static void Main(string[] args)
    {
        var myClass = new MyClass();
        myClass.Name = "Adrian";
        Console.WriteLine(myClass);

        var myRecord = new MyRecord(18, "Adrian");
        Console.WriteLine(myRecord);

        //var myClass = new MyClass();
        //var myClass2 = new MyClass();
        //var myClass3 = myClass2;

        //Console.WriteLine(myClass ==  myClass2);
        //Console.WriteLine(myClass2 == myClass2);
        //Console.WriteLine(myClass2 == myClass3);

        //myClass.GetAccountNo();
        //myClass.GetAccountNo();

        //myClass.IncrementId();
        //myClass.IncrementId();

        //var myRecord1 = new MyRecord(18, "Adrian");
        //var myRecord2 = new MyRecord(18, "Adrian");
        //var myRecord3 = new MyRecord(19, "Adrian");

        //Console.WriteLine(myRecord1 == myRecord2);
        //Console.WriteLine(myRecord2 == myRecord3);

        //var name1 = "Adrian";
        //var name2 = "adrian";

        //Console.WriteLine(name1 == name2);
        //Console.WriteLine(string.Compare(name1, name2, StringComparison.InvariantCulture));
        //Console.WriteLine(name1.CompareTo(name2));

        //myClass.PrintYear();
    }

    public double Test1(int Age, int year)
    {
        int number = 13;
        return number;
    }

    internal int Test2(int Age, int year)
    {
        double number = 13;
        return (int)Math.Floor(number);

        Console.WriteLine(number);
    }

    protected void Test3(int Age, int year)
    {
        
    }

    private string Test4(int Age, int year)
    {
        return "13";
    }

    internal protected string Test5(int Age, int year)
    {
        return "13";
    }
}