
using CSharpLearning;
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharp
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        // Private set should be initialized in Constructor
        public string LastName { get; private set; }

        // Only initialized once
        public readonly DateTime DOB;
        private string _socialID;
        // Manulaly implemented Get Setters with one private field
        public string SocialID
        {
            get
            {
                return _socialID;
            }
            set
            {
                _socialID = value;
            }
        }


        public int Age
        {
            get
            {
                return (DateTime.Today - DOB).Days / 365;
            }
        }

        // Auto implemented property. Here c# created a private field internally
        public List<string> PlacesVisited { get; set; }

        // Indexers
        private readonly Dictionary<string, string> _compnayAndEmpId;
        // Indexers get setter
        public string this[string compnayName]
        {
            get { return _compnayAndEmpId[compnayName]; }
            set { _compnayAndEmpId[compnayName] = value; }
        }



        // Constructors
        // Can not have return type
        // Use Constructors to initialize variables like List etc.
        // Default constructor is created by complier if we don't create it
        public Person()
        {
            this.PlacesVisited = new List<string>();
            this._compnayAndEmpId = new Dictionary<string, string>();
        }

        //Take default costructor impl using 'this'
        public Person(string firstName, string lastName, DateTime dob)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
        }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }

        // Params modifier
        public void AddPlacesVisited(params string[] places)
        {
            this.PlacesVisited.AddRange(places);
        }

        // Can't have this extended method here as class is not Static
        // public static string Greet(this string text)
        //{
        //    return "Hello " + text;
        //}
    }

    public class Employee : Person
    {
        public Employee(string parm1, string parm2, DateTime dob)
            : base(parm1, parm2, dob)
        {

        }


    }

    //Extended Method
    public static class Extendors
    {
        public static string ConvertToUpper(this string text)
        {
            return text.ToUpper();
        }

        public static string Greet(this string text)
        {
            return "Hello " + text;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Manchester", "United", new DateTime(1985, 7, 24));
            //person.Age = 56;
            //person.DOB = new DateOnly();
            person.SocialID = "353253434";
            Console.WriteLine(person.Age);

            person.FirstName = "New FN";
            // Below is invalid as we have private Set;
            //person.LastName = "New LN";

            person["Bosch"] = "B424234";
            Console.WriteLine(person["Bosch"]);

            Console.WriteLine("sunil".ConvertToUpper());
            Console.WriteLine(person.GetName());
            Console.WriteLine(person.GetName().Greet());
            Console.WriteLine(person.SocialID);


            //Animal animalbase = new Animal();
            Animal animalDuck = new Duck();
            Animal animalDog = new Dog();
            Dog dog = new Dog();
            Duck duck = new Duck();
            ISwim swim = new Dog();


            //animalbase.MakeSound();
            animalDuck.MakeSound();
            animalDog.MakeSound();
            dog.MakeSound();
            duck.MakeSound();
            swim.Swim();

            Console.WriteLine("____________________________________________________________");

            Planet planet = new Planet();
            RouguePlanet rouguePlanet = new RouguePlanet();
            Planet planet2 = new RouguePlanet();

            planet.Colour();
            rouguePlanet.Colour();
            planet2.Colour();

            planet.Size();
            rouguePlanet.Size(2);
            planet2.Size();

            PlanetCTOR planetCTOR = new PlanetCTOR();
            PlanetCTOR planetCTOR2 = new PlanetCTOR();

            (new OutRef_Caller()).sendData();

            List<int> list = new List<int>() { 1, 3, 6, 7 };
            List<int> list2 = new List<int>() { 4, 5, 6, 7, 8 };
            Console.WriteLine("IsGreaterThan Generic Extension Method :" + list2.IsGreaterThan(list));

            Teams[] teams = new Teams[10];
            teams[0] = new Teams() { Name = "MU", League = "EPL" };
            Console.WriteLine("");
        }
    }



    public class OutRef_Caller
    {
        OutRef_Callee outRef_Callee = new OutRef_Callee();

        int refNumber;// = 100;
        //int outNumber;// = 100;
        public void sendData()
        {
            outRef_Callee.DataProcessREF(ref refNumber);
            Console.WriteLine("REF: " + refNumber);

            outRef_Callee.DataProcessOUT(out int outNumber);
            Console.WriteLine("OUT: " + outNumber);
        }
    }

    public class OutRef_Callee
    {

        public OutRef_Callee()
        {

        }

        public void DataProcessREF(ref int num)
        {
            num = 99;
        }

        public void DataProcessOUT(out int num)
        {
            num = 10;
        }


    }

    public static class IntExtensions
    {
        public static bool IsGreaterThan<T>(this List<T> A, List<T> B)
        {
            return A.Count > B.Count;
        }
    }

    //Indexer
    public class Teams
    {
        private Teams[] _team;
        public string Name { get; set; }
        public string League { get; set; }

        public Teams this[int index]
        {
            get { return _team[index]; }
            set { _team[index] = value; }
        }

        public void VowelsConsonantsCount(string inputString, out int vowelCount, out int ConsonentCount)
        {
            vowelCount = 0;
            ConsonentCount = 0;

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] charArray = inputString.ToLower().ToCharArray();

            foreach (char item in charArray)
            {
                if (item != ' ')
                {
                    if (vowels.Where(v => v == item).Count() > 0)
                        vowelCount++;
                    else
                        ConsonentCount++;

                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                        vowelCount = vowelCount + 1;
                    else
                        ConsonentCount = ConsonentCount + 1;
                }
            }
        }


        public static void CharactersCount(string inputString)
        {
            var charCountResult = CharCountDictionary(inputString);

            foreach (var count in charCountResult)
            {
                Console.WriteLine(" {0} - {1} ", count.Key, count.Value);
            }
        }

        public static SortedDictionary<char, int> CharCountDictionary(string input)
        {
            SortedDictionary<char, int> countDict = new SortedDictionary<char, int>();

            foreach (char item in input)
            {

                if (!(countDict.ContainsKey(item)))
                {
                    countDict.Add(item, 1);
                }
                else
                {
                    countDict[item]++;
                }
            }
            return countDict;
        }


        public static string RemovingDuplicateCharacters(string inputString)
        {
            string output = string.Empty;
            StringBuilder sbOutput = new StringBuilder();

            foreach (char ch in inputString)
            {
                //if (output.IndexOf(ch) == -1)
                //{
                //    output += ch;
                //}
                if(sbOutput.ToString().IndexOf(ch) == -1)
                {
                    sbOutput.Append(ch);
                }
            }
            return sbOutput.ToString();
        }


    }




}

