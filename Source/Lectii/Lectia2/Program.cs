using Lectia2;

//RunListExample1();
//RunListExample2();
RunListExample3();
//RunMyListExample1();
//RunArrayExample();
RunDictionaryExample();

void RunListExample1()
{
    List<int> ages = new List<int>();

    ages.Add(1);
    ages.Add(2);
    ages.Add(3);
    ages.Add(4);

    ages.Remove(1);

    List<int> ages2 = ages;
    ages[0] = 10;

    foreach (var age in ages)
    {
        //age = 1 + age; // Cannot change value of variable "age"
        Console.WriteLine(age);
    }

    for (int i = 0; i < ages.Count; i++)
        Console.WriteLine(ages[i]);
}

void RunListExample2()
{
    List<int> ages = new List<int>()
    {
        1, 2, 3, 4,
    };

    foreach (var age in ages)
    {
        //age = 1 + age; // Cannot change value of variable "age"
        Console.WriteLine(age);
    }

    for (int i = 0; i < ages.Count; i++)
        Console.WriteLine(ages[i]);
}
void RunListExample3()
{
    List<Person> people = new List<Person>();

    people.Add(new Person("Adrian"));
    Person friend1 = new Person("Dorel");
    people.Add(friend1);
    people.Add(new Person(null));

}

void RunMyListExample1()
{
    MyList<int> ages = new MyList<int>()
    {
        1, 2, 3,
    };

    foreach(var age in ages)
        Console.WriteLine(age);
}

void RunArrayExample()
{
    int[] ages = new int[10];
    int[] ages2 = { 1, 2, 3, };
    int[] ages3 = new int[] { 4, 5, 6, };
    int[] ages4 = ages3;

    ages3[0] = 1;
    
    foreach (var age in ages3)
        Console.WriteLine(age);

    foreach (var age in ages4)
        Console.WriteLine(age);

    //foreach (var age in ages2)
    //    Console.WriteLine(age);

    //foreach (var age in ages3)
    //    Console.WriteLine(age);
}

void RunDictionaryExample()
{
    Dictionary<string, string> preferredClasses = new Dictionary<string, string>();

    preferredClasses["Petru"] = "ACG";
    preferredClasses["Gabi"] = "Databases";
    preferredClasses["Adrian"] = "ACG";
    preferredClasses["Adrian"] = "Microprocesoare";
    preferredClasses.Add("Ion", "Java");
    preferredClasses.Add("Ion", "Java");
    preferredClasses.Remove("Petru");

    foreach (var preferredClass in preferredClasses)
        Console.WriteLine(preferredClass);

    var student = GetStudent();
    
    if (preferredClasses.ContainsKey(student))
    {
        Console.WriteLine(preferredClasses[student]);
    }
    else
    {
        Console.WriteLine("Cannot find student in preferredClasses dictionary");
    }



    string GetStudent() => "Gabl";
}
