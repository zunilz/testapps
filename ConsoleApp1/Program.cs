
using Entities;
using Newtonsoft.Json;
using Oops;
using DataStructureAlgo;
using Patterns;
using System;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

// See https://aka.ms/new-console-template for more information




Algorithms algorithms = new Algorithms();

Console.WriteLine("binarySearch!");

Console.WriteLine(algorithms.binarySearch(88, out int tryCount));
Console.WriteLine(tryCount);
 

Patterns.SingletonDatabaseConnection.getInstance().getConnection();
Patterns.SingletonDatabaseConnection.getInstance().getConnection();
Patterns.SingletonDatabaseConnection.getInstance().getConnection();

INewImplementation newImplementationAdapter 
    = new NewImplementationAdapter(new ExistingImplementation());

//NewImplementationAdapter newImplementationAdapter1 = new NewImplementationAdapter(new ExistingImplementation());
//newImplementationAdapter1.New_processScore();

//newImplementationAdapter.processNewScore();

Console.WriteLine((new ExistingImplementation()).ExistingProcessScore().OuterXml);
Console.WriteLine(JsonConvert.SerializeObject(
    newImplementationAdapter.New_processScore(), Newtonsoft.Json.Formatting.Indented));

Calc calc = new Calc();
Console.WriteLine(calc.add(5,7));

//return;


Console.WriteLine("Hello, World!");

var SO1 = SingleTonObj.Instance;

var SO2 = SingleTonObj.Instance;

var people = new List<PersonHuman>()
{
            new PersonHuman("Bill", "Smith", 40, "United",1),
            new PersonHuman("Sarah", "Jones", 20, "Madrid",2),
            new PersonHuman("Stacy","Baker", 20, "Madrid",3),
            new PersonHuman("Vivianne","Dexter", 19 , "Milan", 1),
            new PersonHuman("Bob","Smith", 50 , "Milan", 1),
            new PersonHuman("Brett","Baker", 50, "United", 2),
            new PersonHuman("Mark","Parker", 19, "Milan", 3),
            new PersonHuman("Alice","Thompson", 18, "Madrid", 2),
            new PersonHuman("Evelyn","Thompson", 18, "United", 3),
            new PersonHuman("Mort","Martin", 60, "Milan", 2),
            new PersonHuman("Eugene","deLauter", 80 , "Madrid", 1),
            new PersonHuman("Gail","Dawson", 19, "United", 2),

 };

List<Country> country = new List<Country>();
country.Add(new Country() { Id = 1, Name = "India" });
country.Add(new Country() { Id = 2, Name = "US" });
country.Add(new Country() { Id = 3, Name = "Norway" });

var resultSet = from person in people
                where person.Age < 50
                orderby person.Age descending
                select person;

//Console.WriteLine(JsonConvert.SerializeObject(
//    resultSet, Newtonsoft.Json.Formatting.Indented));

 

var groupResult = people.GroupBy(x => x.Team).ToList();


Console.WriteLine(); Console.WriteLine();
Console.WriteLine(JsonConvert.SerializeObject(
    groupResult, Newtonsoft.Json.Formatting.Indented));


Console.WriteLine(); Console.WriteLine();
Console.WriteLine(

    people.Select(p => p.Age).Average()

    );

Console.WriteLine(); Console.WriteLine();
Console.WriteLine(JsonConvert.SerializeObject(

    people
    .GroupBy(x => x.Team)
    .Select(p =>
        new
        {
            dep = p.Key,
            Avg = p.Max(x => x.Age)
        })
    //.Where(r => r.Avg > 40)
    , Newtonsoft.Json.Formatting.Indented));

Console.WriteLine(); Console.WriteLine();
Console.WriteLine(JsonConvert.SerializeObject(

    people
    .GroupBy(x => x.Team)
    .Select(p =>
        new
        {
            dep = p.Key,
            Avg = p.Min(i => i.Age)
        })
    , Newtonsoft.Json.Formatting.Indented));

Console.WriteLine(); Console.WriteLine();
Console.WriteLine(JsonConvert.SerializeObject(

    people
    .Join(country, p
        => p.CountryId, c => c.Id,
        (people, country) => new
        {
            Name = people.ToString(),
            Country = country.Name
        }
        )
    , Newtonsoft.Json.Formatting.Indented));

Console.WriteLine(); Console.WriteLine();
Console.WriteLine(JsonConvert.SerializeObject(

    country
    .GroupJoin(people, c
        => c.Id, p => p.CountryId,
        (c, p) => new
        {
            Key = c.Name,
            Total = p.Count(),
            People = p
        }
        )
    , Newtonsoft.Json.Formatting.Indented));

//var result = languages.GroupJoin(persons, lang
//    => lang.Id, pers => pers.LanguageId,
//        (lang, ps) => new 
//        {
//            Key = lang.Name, 
//            Persons = ps
//        });
