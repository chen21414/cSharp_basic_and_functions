using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings  
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");

            // Read all data  
            Console.WriteLine("Authors List");
            foreach (var author in AuthorList)
            {
                Console.WriteLine(author);
            }
        }
    }
}