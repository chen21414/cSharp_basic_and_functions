using System;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

namespace MyNamespace
{
    public class Tool
    {
        public static void SayHi() //static method is belonging to class
        {
            Console.Write("Hello");
        }
    }

}

//back to program.cs

Tool.SayHi();// can use directly

Math math = new Math(); //can't do this because Math was a static class


//
namespace MyNamespace
{
    public static class Tool //like Math
    {
        public static void SayHi() //static method is belonging to class
        {
            Console.Write("Hello");
        }
    }

}

Tool tool = new Tool(); //can't do