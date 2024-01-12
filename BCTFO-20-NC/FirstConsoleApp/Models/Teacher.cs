namespace FirstConsoleApp.Models
{
    public class Teacher : Employee
    {
        public string Subject { get; set; }

        public override void SayHello()
        {
            Console.WriteLine($"Hello i am {FirstName} {LastName} {PhoneNumber} {Salary} {Subject}");
        }
    }
}
