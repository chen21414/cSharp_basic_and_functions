using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//C# add strings with + operator
var a = "an old";
var b = " falcon";

var c = a + b;
Console.WriteLine(a + b);


//C# add strings with string.Concat
var a = "and old";
var b = " eagle";

var c = string.Concat(a, b);

Console.WriteLine(c);


//C# add strings with string.Join
var words = new List<string> { "There", "are", "two", "owls", "on", "the", "tree" };
var msg = string.Join(" ", words);

Console.WriteLine(msg);

// $ dotnet run
// There are two owls on the tree


//C# add strings with StringBuilder
using System.Text;

var builder = new StringBuilder("There");

builder.Append(" are");
builder.Append(" two");
builder.Append(" falcons");
builder.Append(" in");
builder.Append(" the");
builder.Append(" sky");

Console.WriteLine(builder);