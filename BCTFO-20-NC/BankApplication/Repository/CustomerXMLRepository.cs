using BankApplication.Models;
using BankApplication.Repository.Interfaces;
using System.Xml;

namespace BankApplication.Repository
{
    public class CustomerXMLRepository : IRepository
    {
        private const string _fileLocation = "C:\\Users\\User\\Desktop\\IT STEP\\BCTFO-20-NC\\BCTFO-20-NC\\BankApplication\\Customers.xml";
        private List<Customer> _data = new();

        public CustomerXMLRepository()
        {
            _data = Parse(File.ReadAllText(_fileLocation));
        }

        private static List<Customer> Parse(string input)
        {
            List<Customer> result = new();

            XmlDocument xDoc = new();
            xDoc.LoadXml(input);

            XmlNodeList rowNodes = xDoc.SelectNodes("//Customer");

            foreach (XmlNode rowNode in rowNodes)
            {
                Customer customer = new();

                customer.Id = int.Parse(rowNode.SelectSingleNode("Id").InnerText);
                customer.Name = rowNode.SelectSingleNode("Name").InnerText;
                customer.IdentityNumber = rowNode.SelectSingleNode("IdentityNumber").InnerText;
                customer.PhoneNumber = rowNode.SelectSingleNode("PhoneNumber").InnerText;
                customer.Email = rowNode.SelectSingleNode("Email").InnerText;
                customer.Type = int.Parse(rowNode.SelectSingleNode("Type").InnerText);

                result.Add(customer);
            }

            return result;
        }

        public void AddNewCustomer(Customer model)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
