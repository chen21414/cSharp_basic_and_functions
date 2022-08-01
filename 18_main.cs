using System;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;


//this is how c# is runnign
namespace Animal //using namespace in program.cs means can directly use person1 instead of using Animal on top
{
    public class Program
    {
        static void Main()
        {


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