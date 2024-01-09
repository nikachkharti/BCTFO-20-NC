namespace FirstConsoleApp.Models
{
    public class Customer : Person
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


        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@') && value.Contains('.'))
                {
                    email = value;
                }
            }
        }

        public double Salary { get; set; }
    }
}
