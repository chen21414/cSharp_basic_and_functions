using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//C# closure example
var c = CreateCounter();

Console.WriteLine(c());
Console.WriteLine(c());
Console.WriteLine(c());
Console.WriteLine(c());
Console.WriteLine(c());

Func<int> CreateCounter()
{
    int c = 0;
    return () => c = c + 1;
}

// $ dotnet run
// 1
// 2
// 3
// 4
// 5

// Func is a delegate that points to a method that accepts one or more arguments and returns a value. 
// Action is a delegate that points to a method which in turn accepts one or more arguments but returns no value. 
// In other words, you should use Action when your delegate points to a method that returns void.

//C# closure example II
var vals = new int[] { -1, -2, 0, 1, 5, 3 };

var limit = 0;
Func<int, bool> greaterThan = e => e > limit;

var res = vals.Where(greaterThan);

foreach (var e in res)
{
    Console.WriteLine(e);
}



//C# closure example III ***??
var words = new List<string> { "sky", "cloud", "rock", "war", "web" };
var it = CreateIterator(words);

string e;

while ((e = it()) != null)
{
    Console.WriteLine(e);
}

Iterator<T> CreateIterator<T>(IList<T> data) where T : class
{
    var i = 0;
    return delegate { return (i < data.Count) ? data[i++] : null; };
}

public delegate T Iterator<T>() where T : class;


// A delegate is a type that safely encapsulates a method, similar to a function pointer in C and C++. 
// Unlike C function pointers, delegates are object-oriented, type safe, and secure. 
// The type of a delegate is defined by the name of the delegate. 
// The following example declares a delegate named Del that can encapsulate a method that takes a string as an argument and returns void:

// An iterator, in the context of C#, is a block of code that returns an ordered sequence of values of a collection or array. 
// It is a member function implemented using the iterator block, which contains one or more statements containing the "yield" keyword.
public delegate void Del(string message);

// Create a method for a delegate.
public static void DelegateMethod(string message)
{
    Console.WriteLine(message);
}

// Instantiate the delegate.
Del handler = DelegateMethod;

// Call the delegate.
handler("Hello World");


