using BankApplication.Models;
using BankApplication.Repository.Interfaces;
using System.Text.Json;

namespace BankApplication.Repository
{
    public class CustomerJSONRepository : IRepository
    {
        private const string _fileLocation = "C:\\Users\\User\\Desktop\\IT STEP\\BCTFO-20-NC\\BCTFO-20-NC\\BankApplication\\Customers.json";
        private List<Customer> _data = new();

        public CustomerJSONRepository()
        {
            _data = Parse(File.ReadAllText(_fileLocation));
        }

        private static List<Customer> Parse(string input)
        {
            List<Customer> result = JsonSerializer.Deserialize<List<Customer>>(input);

            if (result == null)
            {
                throw new FormatException("Invalid format while deserialization");
            }

            return result;
        }

        private static string ToJson(Customer model)
        {
            string jsonObject = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
            return jsonObject;
        }


        public void AddNewCustomer(Customer model)
        {
            model.Id = _data.Max(x => x.Id) + 1;

            var result = ToJson(model);
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
            if (!input.StartsWith("{") || !input.EndsWith("}"))
            {
                throw new FormatException("Input is not valid JSON format");
            }

            if (!File.Exists(_fileLocation))
            {
                File.WriteAllText(_fileLocation, "[]");
            }

            string existingJson = File.ReadAllText(_fileLocation);

            if (!string.IsNullOrWhiteSpace(existingJson))
            {
                existingJson = existingJson.Trim(']');
            }

            input = $",{input}";

            File.WriteAllText(_fileLocation, $"{existingJson}{input}]");

        }
    }
}
