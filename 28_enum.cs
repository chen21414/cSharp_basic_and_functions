using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

Day day = Day.Monday;

if (day == Day.Monday)
{
    Console.WriteLine("It is Monday");
}

Console.WriteLine(day);

foreach (int i in Enum.GetValues(typeof(Day)))
{
    Console.WriteLine(i);
}

enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

// $ dotnet run
// It is Monday
// Monday
// 0
// 1
// 2
// 3
// 4
// 5
// 6


//
foreach (int i in Enum.GetValues(typeof(Days)))
{
    Console.WriteLine(i);
}

enum Days
{
    Monday,
    Tuesday,
    Wednesday = 8,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

// $ dotnet run
// 0
// 1
// 8
// 9
// 10
// 11
// 12


//enum different type for members
Season s1 = Season.Spring;
Season s2 = Season.Autumn;

Console.WriteLine(s1);
Console.WriteLine(s2);

Console.WriteLine("----------------------");

Console.WriteLine(s1.GetType());
Console.WriteLine(Enum.GetUnderlyingType(s1.GetType()));

enum Season : byte
{
    Spring = 1,
    Summer = 2,
    Autumn = 3,
    Winter = 4
}

// $ dotnet run
// Spring
// Autumn
// ----------------------
// Season
// System.Byte


//https://zetcode.com/csharp/enum/