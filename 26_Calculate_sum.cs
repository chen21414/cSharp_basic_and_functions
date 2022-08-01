using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//1. Using Enumerable.Sum() method
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int sum = array.Sum();
        Console.WriteLine(sum);
    }
}

//2. Using Array.ForEach() method
using System;
 
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int sum = 0;
        Array.ForEach(array, i => sum += i);

        Console.WriteLine(sum);
    }
}


//3. Using foreach loop
using System;
 
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int sum = 0;
        foreach (int item in array)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}


//4. Using Enumerable.Aggregate() method
using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int sum = array.Aggregate((total, next) => total + next);
        Console.WriteLine(sum);
    }
}