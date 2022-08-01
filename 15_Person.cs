using System;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;



//class, object
namespace ConsoleApp1
{
    public class Person
    {
        public double height;
        public int age;
        public string name;
    }

}

//back to program.cs
Person person1 = new Person();

person1.height = 170.5;
person1.age = 42;
person1.name = "dark";

//
Person person2 = new Person();

person2.height = 170.5;
person2.age = 42;
person2.name = "dark";