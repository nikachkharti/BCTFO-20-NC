using BankApplication.Models;
using BankApplication.Repository.Interfaces;

namespace BankApplication.Repository
{
    public class CustomerCSVRepository : IRepository
    {
        private const string _fileLocation = "C:\\Users\\User\\Desktop\\IT STEP\\BCTFO-20-NC\\BCTFO-20-NC\\BankApplication\\Customers.csv";
        private List<Customer> _data = new();
        public CustomerCSVRepository()
        {
            using (StreamReader reader = new(_fileLocation))
            {
                //პირველი ხაზის გამოტოვება
                reader.ReadLine();

                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    Customer parsedCustomer = Parse(line);
                    _data.Add(parsedCustomer);
                }
            }

            //_data = File
            //    .ReadAllLines(_fileLocation)
            //    .Skip(1)
            //    .Select(Parse)
            //    .ToList();
        }

        private static Customer Parse(string input)
        {
            var data = input.Split(',');

            if (data.Length != 6)
            {
                throw new FormatException("Incorrect format");
            }

            var result = new Customer();
            result.Id = int.Parse(data[0]);
            result.Name = data[1];
            result.IdentityNumber = data[2];
            result.PhoneNumber = data[3];
            result.Email = data[4];
            result.Type = int.Parse(data[5]);

            return result;
        }

        private static string ToCSV(Customer model) => $"{model.Id},{model.Name},{model.IdentityNumber},{model.PhoneNumber},{model.Email},{model.Type}";

        public void AddNewCustomer(Customer model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            model.Id = _data.Max(x => x.Id) + 1;

            var result = ToCSV(model);
            Save(result);
        }

        public List<Customer> GetAllCustomers()
        {
            if (_data.Count <= 0)
            {
                throw new Exception("Data storage is empty");
            }

            return _data;
        }

        public Customer GetSingleCustomer(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var result = _data.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                throw new NullReferenceException("Item not found");
            }

            return result;
        }

        public void Save(string input)
        {
            using (StreamWriter writer = new(_fileLocation, append: true))
            {
                writer.Write($"\n{input}");
            }

            //File.AppendAllText(_fileLocation, $"\n{input}");
        }
    }
}
