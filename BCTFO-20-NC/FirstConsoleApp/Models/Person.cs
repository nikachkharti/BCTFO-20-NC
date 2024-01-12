namespace FirstConsoleApp.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayHello();

    }
}
