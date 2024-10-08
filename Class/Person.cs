using System;
using System.Reflection.Metadata.Ecma335;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name,int age)
    {
        Name = name;
        Age = age;
    }

    public void Human()
    {
        Console.WriteLine("Personnal info: " + Name + Age);
    }
}