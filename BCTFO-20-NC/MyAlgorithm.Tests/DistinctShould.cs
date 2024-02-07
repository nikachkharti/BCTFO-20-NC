namespace MyAlgorithm.Tests
{
    public class DistinctShould
    {
        [Fact]
        public void Find_Unique_Value_Elements()
        {
            //Arrange
            List<int> dataToTest = new() { 1, 2, 2, 2, 3, 3, 4, 4 };
            List<string> names = new() { "Aleksandre", "Levani", "Giorgi", "Giorgi", "Giorgi" };

            List<int> expected = new() { 1, 2, 3, 4 };
            List<string> expectedNames = new() { "Aleksandre", "Levani", "Giorgi" };

            //Act
            List<int> actual = MyAlgorithms.Distinct(dataToTest).ToList();
            List<string> actualNames = MyAlgorithms.Distinct(names).ToList();

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expectedNames, actualNames);
        }

        [Fact]
        public void Find_Unique_Reference_Elements()
        {
            List<Person> peopleToTest = new()
            {
                new Person() {FirstName = "Nika",LastName = "Chkahrtishvili"},
                new Person() {FirstName = "Nika",LastName = "Chkahrtishvili"},
                new Person() {FirstName = "Giorgi",LastName = "Giorgadze"},
                new Person() {FirstName = "Daviti",LastName = "Davitashvili"},
                new Person() {FirstName = "Daviti",LastName = "Davitashvili"}
            };

            var expected = new List<Person>()
            {
                new Person() {FirstName = "Nika",LastName = "Chkahrtishvili"},
                new Person() {FirstName = "Giorgi",LastName = "Giorgadze"},
                new Person() {FirstName = "Daviti",LastName = "Davitashvili"}
            };


            var actual = MyAlgorithms.Distinct(peopleToTest, new PersonEquilityComparer());

            Assert.Equal(expected, actual, new PersonEquilityComparer());
        }
    }
}
