using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//C# split string simple example
var text = "There is an old hawk in the sky";

var words = text.Split(' ');
Array.ForEach(words, Console.WriteLine);

// $ dotnet run
// There
// is
// an
// old
// hawk
// in
// the
// sky



//C# split string and omit empty entries
var text = "There  is an old  hawk in the sky";

var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Array.ForEach(words, Console.WriteLine);



//C# split string by multiple characters
var text = "falcon;eagle,forest,sky;cloud,water,rock;wind";

var words = text.Split(new char[] { ',', ';' });
Array.ForEach(words, Console.WriteLine);


//C# String.Join
var words = new List<string> { "falcon", "wood", "sky", "water" };

var text = String.Join(',', words);
Console.WriteLine(text);

// $ dotnet run
// falcon,wood,sky,water