using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using ConsoleApp1;
using Internal;
using MyNamespace;

//1.filter list with iteration
var words = new List<string> { "sky", "rock", "forest", "new",
    "falcon", "jewelry" };

var filtered = new List<string>();

foreach (var word in words)
{
    if (word.Length == 3)
    {
        filtered.Add(word);
    }
}

Console.WriteLine(string.Join(',', filtered));


//2.filter list with FindAll
var vals = new List<int> { -1, -3, 0, 1, 3, 2, 9, -4 };

List<int> filtered = vals.FindAll(e => e > 0);

Console.WriteLine(string.Join(',', filtered));



//3.filter list with LINQ query expression
var words = new List<string> { "sky", "rock", "forest", "new",
        "falcon", "jewelry" };

var query = from word in words
            where word.Length == 3
            select word;

foreach (var word in query)
{
    Console.WriteLine(word);
}


//4. filter list with LINQ Where
var vals = new List<int> { -1, -3, 0, 1, 3, 2, 9, -4 };

List<int> filtered = vals.Where(x => x > 0).ToList();

Console.WriteLine(string.Join(',', filtered));




//5. filter a list of objects
var cars = new List<Car>
{
    new ("Audi", 52642),
    new ("Mercedes", 57127),
    new ("Skoda", 9000),
    new ("Volvo", 29000),
    new ("Bentley", 350000),
    new ("Citroen", 21000),
    new ("Hummer", 41400),
    new ("Volkswagen", 21601)
};

foreach (var car in from car in cars
                    where car.Price > 9000 && car.Price < 50000
                    select new { car.Name, car.Price })
{
    Console.WriteLine($"{car.Name} {car.Price}");
}

record Car(string Name, int Price);



//6. filter an array with Func
User[] users =
{
  new (1, "John", "London", "2001-04-01"),
  new (2, "Lenny", "New York", "1997-12-11"),
  new (3, "Andrew", "Boston", "1987-02-22"),
  new (4, "Peter", "Prague", "1936-03-24"),
  new (5, "Anna", "Bratislava", "1973-11-18"),
  new (6, "Albert", "Bratislava", "1940-12-11"),
  new (7, "Adam", "Trnava", "1983-12-01"),
  new (8, "Robert", "Bratislava", "1935-05-15"),
  new (9, "Robert", "Prague", "1998-03-14"),
};

var city = "Bratislava";
Func<User, bool> livesIn = e => e.City == city;
// In the predicate, a function which returns a boolean value, 
// we test all user objects whose City attribute is equal to the city variable.
var res = users.Where(livesIn);

foreach (var e in res)
{
    Console.WriteLine(e);
}

record User(int id, string Name, string City, string DateOfBirth);
