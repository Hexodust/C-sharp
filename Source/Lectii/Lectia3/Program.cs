using Lectia3Gabi;

var name = "Adrian";

var person1 = new Person();
//person1.Talk();
person1.Talk(name);

var person2 = new Student();
//person2.Talk();
person2.Talk(name);

var person3 = new Phd();
//person3.Talk();
person3.Talk(name);

Console.ReadKey();