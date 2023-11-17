namespace Lectia1;

internal class Runner : Program
{
    public void Start()
    {
        var program = new Program();
        var age = 18;
        var year = 1900;
        program.Test2(age, year);

        //program.Test3(age, year);

        Test3(age, year);

        //program.Test4(age, year);
        //Test4(age, year);

        program.Test5(age, year);
        Test5(age, year);
    }
}
