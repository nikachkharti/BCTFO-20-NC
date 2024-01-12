namespace FirstConsoleApp.Models
{
    public class Callcenter : Employee
    {
        public string PhoneNumbers { get; set; }

        public override void SayHello()
        {
            Console.WriteLine($"Hello i am {FirstName} {LastName} {PhoneNumber} {Salary} {PhoneNumbers}");
        }
    }
}
