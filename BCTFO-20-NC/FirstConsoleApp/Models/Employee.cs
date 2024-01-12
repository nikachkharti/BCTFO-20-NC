namespace FirstConsoleApp.Models
{
    public abstract class Employee : Person
    {
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length == 9)
                {
                    phoneNumber = value;
                }
            }
        }

        public double Salary { get; set; }
    }
}
