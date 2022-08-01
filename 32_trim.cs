using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

// C# trim string
// last modified July 13, 2022

// C# trim string tutorial shows how to trim strings in C# language with String.Trim, String.TrimStart and String.TrimEnd. 
// C# tutorial is a comprehensive tutorial on C# language.

// The String.Trim method removes all leading and trailing white-space characters from the current string. 
// The overloaded String.Trim(Char[]) method removes all leading and trailing occurrences of a set of characters specified in an array from the current string.

// The String.TrimStart method removes all leading and the String.TrimEnd all trailing characters or set of characters from the string.



var word = "\tfalcon  ";

Console.WriteLine(word.Length);

var word2 = word.TrimStart();
Console.WriteLine(word2.Length);

var word3 = word.TrimEnd();
Console.WriteLine(word3.Length);

var word4 = word.Trim();
Console.WriteLine(word4.Length);


//


//C# trim string example II
var text = "Look! There is a hawk in the sky. Do you have a camera?";
var words = text.Split(' ');

Array.ForEach(words, word =>
{

    Console.WriteLine(word.TrimEnd(new char[] { '?', '.', '!' }));
});