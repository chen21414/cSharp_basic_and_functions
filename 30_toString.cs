using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//C# default ToString
var u1 = new User("John Doe", "gardener");
var u2 = new User("Roger Roe", "driver");

Console.WriteLine(u1);
Console.WriteLine(u2);

class User
{
    private string Name { get; set; }
    private string Occupation { get; set; }

    public User(string Name, string Occupation) =>
        (this.Name, this.Occupation) = (Name, Occupation);
}

// We have a User class which has not overriden the ToString method; it uses the default one from its parent.

// Console.WriteLine(u1);


//C# override ToString
var u1 = new User("John Doe", "gardener");
var u2 = new User("Roger Roe", "driver");

Console.WriteLine(u1);
Console.WriteLine(u2);

class User
{
    private string Name { get; set; }
    private string Occupation { get; set; }

    public User(string Name, string Occupation) =>
        (this.Name, this.Occupation) = (Name, Occupation);

    public override string ToString()
    {
        return $"User {{ {Name} {Occupation} }}";
    }
}

// $ dotnet run
// User { John Doe gardener }
// User { Roger Roe driver }


//C# record ToString
var u1 = new User("John Doe", "gardener");
var u2 = new User("Roger Roe", "driver");

Console.WriteLine(u1);
Console.WriteLine(u2);

record User(string Name, string Occupation);

// $ dotnet run
// User { Name = John Doe, Occupation = gardener }
// User { Name = Roger Roe, Occupation = driver }


//C# DateTime ToString
using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var d1 = DateTime.Now;
Console.WriteLine(d1);

string fmt = "MMMM dd, yyyy (dddd)";

var d2 = new DateTime(2020, 5, 20);
Console.WriteLine(d2.ToString(fmt));

var d3 = new DateTime(2021, 3, 30);
Console.WriteLine(d3.ToShortDateString());

DateTime now = DateTime.Now;
CultureInfo ci = new CultureInfo("sk-SK");
Console.WriteLine($"Dnešný dátum a čas: {now.ToString("F", ci)}");


// $ dotnet run
// 4/8/2021 1:14:43 PM
// May 20, 2020 (Wednesday)
// 3/30/2021
// Dnešný dátum a čas: štvrtok 8. apríla 2021 13:14:43


//https://zetcode.com/csharp/object-tostring/