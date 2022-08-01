using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

class Program
{
    public static int CalculateSumRecursively(int n, int m)
    {
        int sum = n;
        if (n < m)
        {
            n++;
            return sum += CalculateSumRecursively(n, m);
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int sum = CalculateSumRecursively(n, m);
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}


//example 2
class Program
{
    public static int CountDivisions(double number)
    {
        int count = 0;
        if (number > 0 && number % 2 == 0)
        {
            count++;
            number /= 2;
            return count += CountDivisions(number);
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number: ");
        double number = Convert.ToDouble(Console.ReadLine());
        int count = CountDivisions(number);
        Console.WriteLine($"Total number of divisions: {count}");
        Console.ReadKey();
    }
}


