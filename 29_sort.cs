using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

var nums = new List<int> { 2, 1, 8, 0, 4, 3, 5, 7, 9 };

nums.Sort();
Console.WriteLine(string.Join(",", nums));

nums.Reverse();
Console.WriteLine(string.Join(",", nums));


//C# List sort strings
var words = new List<string> {"falcon", "order", "war",
                "sky", "ocean", "blue", "cloud", "boy"};

words.Sort();
Console.WriteLine(string.Join(",", words));

words.Reverse();
Console.WriteLine(string.Join(",", words));


//C# List sort by string length
var words = new List<string> {"falcon", "order", "war",
        "sky", "ocean", "blue", "cloud", "boy", "by", "raven",
        "station", "batallion"};

words.Sort((a, b) => a.Length.CompareTo(b.Length));
Console.WriteLine(string.Join(",", words));

words.Sort((a, b) => b.Length.CompareTo(a.Length));
Console.WriteLine(string.Join(",", words));


//C# List sort names by surname
var names = new List<string> {"John Doe", "Lucy Smith",
        "Benjamin Young", "Robert Brown", "Thomas Moore",
        "Linda Black", "Adam Smith", "Jane Smith"};

names.Sort((n1, n2) => n1.Split(" ")[1].CompareTo(n2.Split(" ")[1]));
Console.WriteLine(string.Join(",", names));


//C# List sort with Comparison
var employees = new List<(string, int)>
{
    ("John Doe", 1230),
    ("Adam Novak", 670),
    ("Robin Brown", 2300),
    ("Rowan Cruise", 990),
    ("Joe Draker", 1190),
    ("Janet Doe", 980),
    ("Lucy Smith", 980),
    ("Thomas Moore", 1400)
};

employees.Sort(delegate ((string, int) emp1, (string, int) emp2)
{
    return emp1.Item2.CompareTo(emp2.Item2);
});

Console.WriteLine(string.Join(Environment.NewLine, employees));

// When would you use delegates in C#?
// Delegates are used to define callback methods and implement event handling, 
// and they are declared using the “delegate” keyword.


//C# List sort with IComparable
var employees = new List<Employee>
{
    new Employee("John Doe", 1230),
    new Employee("Adam Novak", 670),
    new Employee("Robin Brown", 2300),
    new Employee("Rowan Cruise", 990),
    new Employee("Joe Draker", 1190),
    new Employee("Janet Doe", 980),
    new Employee("Lucy Smith", 980),
    new Employee("Thomas Moore", 1400)
};

employees.Sort();

Console.WriteLine(string.Join(Environment.NewLine, employees));

record Employee(string Name, int Salary) : IComparable<Employee>
{
    public int CompareTo(Employee other)
    {
        return other.Salary.CompareTo(this.Salary);
    }
};


//C# List sort with IComparer
var employees = new List<(string, int)>
{
    ("John Doe", 1230),
    ("Adam Novak", 670),
    ("Robin Brown", 2300),
    ("Rowan Cruise", 990),
    ("Joe Draker", 1190),
    ("Janet Doe", 980),
    ("Lucy Smith", 980),
    ("Thomas Moore", 1400)
};

employees.Sort(new SurnameComparer());
employees.ForEach(employee => Console.WriteLine(employee));

class SurnameComparer : IComparer<(string, int)>
{
    public int Compare((string, int) e1, (string, int) e2)
    {
        return e1.Item1.Split()[1].CompareTo(e2.Item1.Split()[1]);
    }
}



//C# List sort tuples
var data = new List<(string Name, int Grade)>
{
    ("Patrick", 89),
    ("Lucia", 92),
    ("Veronika", 72),
    ("Robert", 78),
    ("Maria", 65),
    ("Andrea", 51),
    ("Ondrej", 45)
};

data.Sort((s1, s2) => s1.Grade.CompareTo(s2.Grade));
Console.WriteLine(string.Join(", ", data));

data.Sort((s1, s2) => s2.Grade.CompareTo(s1.Grade));
Console.WriteLine(string.Join(", ", data));

// $ dotnet run
// (Ondrej, 45), (Andrea, 51), (Maria, 65), (Veronika, 72), (Robert, 78), ...
// (Lucia, 92), (Patrick, 89), (Robert, 78), (Veronika, 72), (Maria, 65), ...


//C# List sort objects
var users = new List<User>();
users.Add(new User("John", "Doe", 1230));
users.Add(new User("John", "Doe", 1230));
users.Add(new User("Lucy", "Novak", 670));
users.Add(new User("Ben", "Walter", 2050));
users.Add(new User("Robin", "Brown", 2300));
users.Add(new User("Joe", "Draker", 1190));
users.Add(new User("Janet", "Doe", 980));

users.Sort((u1, u2) => u1.LastName.CompareTo(u2.LastName));
users.ForEach(user => Console.WriteLine(user));

record User(string FirstName, string LastName, int Salary);


//C# List sort DateTime
var users = new List<User>();
users.Add(new User("John", "Doe", new DateTime(1983, 9, 4)));
users.Add(new User("Lucy", "Novak", new DateTime(1978, 11, 18)));
users.Add(new User("Ben", "Walter", new DateTime(1998, 12, 1)));
users.Add(new User("Robin", "Brown", new DateTime(2001, 2, 14)));
users.Add(new User("Joe", "Draker", new DateTime(1980, 1, 10)));
users.Add(new User("Janet", "Doe", new DateTime(1967, 8, 23)));

Console.WriteLine("sort ascending by birthday");
users.Sort((u1, u2) => DateTime.Compare(u1.Birthday, u2.Birthday));
users.ForEach(u => Console.WriteLine(u));

Console.WriteLine("--------------------------");
Console.WriteLine("sort descending by birthday");

var enum1 = users.OrderByDescending(e => e.Birthday);
foreach (var u in enum1)
{
    Console.WriteLine(u);
}

Console.WriteLine("--------------------------");
Console.WriteLine("sort ascending by birthday");

var enum2 = from user in users
            orderby user.Birthday
            select user;

foreach (var u in enum2)
{
    Console.WriteLine(u);
}

record User(string FirstName, string LastName, DateTime Birthday);


//https://zetcode.com/csharp/sortlist/