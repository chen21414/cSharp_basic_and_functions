using System;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;


//namespace
namespace Animal
{
    public class Person
    {
        public double height;
        public int age;
        public string name;
    }

}

namespace house
{

}

//back to program.cs
Animal.Person person1 = new Animal.Person();

person1.height = 170.5;
person1.age = 42;
person1.name = "dark";

// or
using Animal;
Person person2 = new Person();

person2.height = 170.5;
person2.age = 42;
person2.name = "dark";

//
//namespace within a namespace
namespace Animal
{
    namespace qq
    {
        public class Person
        {
            public double height;
            public int age;
            public string name;
        }

    }

}

using Animal.qq;
using System;