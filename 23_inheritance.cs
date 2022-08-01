using System;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

class Stuent : Person
{
    public string school;
    //name and age got them from Person
    public Student(string name, int age, string school)
    {
        this.name = name;
        this.age = age;
        this.school = school;
    }

}

//program.cs

Student student1 = new Student("white", 10, "white elementary");

Console.Write(student1.name);