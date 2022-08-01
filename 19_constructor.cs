using System;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;


class Person
{
    public double height;
    public int age;
    public string name;

    public Person(double height, int age, string name) //no need for void because not returing data
    {
        //Console.Write("success" + qq);//show up twice, because we have person1 person2 in the program.cs

        this.height = height;
        this.age = age;
        this.name = name;

    }
}


//back to program.cs
public class Program
{
    static void Main()
    {

        Animal.Person person1 = new Animal.Person(170.5, 42, "dark");
        // person1.height = 170.5;
        // person1.age = 42;
        // person1.name = "dark";

        // or
        using Animal;
        Person person2 = new Person(160.6, 16, "orange");
        // person2.height = 170.5;
        // person2.age = 42;
        // person2.name = "dark";

        Console.Write(person1.name);
    }

}
