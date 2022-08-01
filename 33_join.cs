using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//C# join string - array of objects
object[] vals = { 1, 2.3, false, "falcon" };

var text = string.Join("-", vals);
Console.WriteLine(text);

// $ dotnet run
// 1-2.3-False-falcon


//https://zetcode.com/csharp/joinstring/