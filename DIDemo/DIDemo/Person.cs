using System.Reflection.Metadata;

namespace DIDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}