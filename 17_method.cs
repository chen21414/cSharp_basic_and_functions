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

        public void SayHi()
        {
            Console.Write("hi" + name);
        }

        public bool isAdult() //using bool because below is true/false
        {
            if (age >= 18)
            {
                //Console.Write(true);
                return true;
            }
            else
            {
                //Console.Write(false);
                return false;
            }
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }

}


//back to program.cs
using Animal;
Person person1 = new Person();

person1.height = 170.5;
person1.age = 42;
person1.name = "dark";
person1.SayHi();
person1.isAdult();

if (person1.isAdult())
{
    //access to website
}

person1.Add(2, 3);