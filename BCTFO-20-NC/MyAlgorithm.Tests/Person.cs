using System.Diagnostics.CodeAnalysis;

namespace MyAlgorithm.Tests
{
    public class PersonEquilityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y) => x.FirstName == y.FirstName && x.LastName == y.LastName;
        public int GetHashCode([DisallowNull] Person obj) => obj.FirstName.Length + obj.LastName.Length;
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
