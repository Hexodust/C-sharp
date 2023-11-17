﻿namespace Lectia1.CustomTypes;

public struct MyStruct
{
    public string Name;
    public string Value;

    public MyStruct(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public void SayHi()
    {
        Console.WriteLine("HI");
    }
}
