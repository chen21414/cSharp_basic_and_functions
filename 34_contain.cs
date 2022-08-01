using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//C# Contains
var text = "An old hawk in the sky";
var word = "hawk";

if (text.Contains(word))
{
    Console.WriteLine($"The text contains the {word} word");
}
else
{
    Console.WriteLine($"The text does not contain the {word} word");
}


//C# StartsWith and EndsWith
var text = "old hawk";

if (text.StartsWith("old"))
{
    Console.WriteLine("The text starts with the old string");
}
else
{
    Console.WriteLine("The text does not with the old string");
}

if (text.EndsWith("hawk"))
{
    Console.WriteLine("The text ends with the hawk string");
}
else
{
    Console.WriteLine("The text does not end with the hawk string");
}


//C# IndexOf and LastIndexOf
var text = "There is an old hawk in the sky. The sun is shining.";
var word = "is";

int first = text.IndexOf(word);
int last = text.LastIndexOf(word);

Console.WriteLine($"The first index of the word {word}: {first}");
Console.WriteLine($"The last index of the word {word}: {last}");