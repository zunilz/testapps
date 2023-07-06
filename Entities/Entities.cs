namespace Entities
{
    
    public class PersonHuman
    {
        public PersonHuman(string firstName, string lastName, int age, string team, int countryId)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Team = team;
            CountryId = countryId;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CountryId { get; set; }

        public string Team { get; set; }

        //override ToString to return the person's FirstName LastName Age
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    public class Country
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Country()
        {
            
        }
        public Country(string name)
        {
            Name = name;
        }
    }
}
