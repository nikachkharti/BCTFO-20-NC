using BankApplication.Models;

namespace BankApplication.Repository.Interfaces
{
    public interface IRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetSingleCustomer(int id);
        void AddNewCustomer(Customer model);
        void Save(string input);
    }
}
