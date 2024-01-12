namespace FirstConsoleApp.Models
{
    public class Administration : Employee
    {
        public string Password { get; set; }

        public override void SayHello()
        {
            Console.WriteLine($"Hello i am {FirstName} {LastName} {PhoneNumber} {Salary} {Password}");
        }
    }
}
