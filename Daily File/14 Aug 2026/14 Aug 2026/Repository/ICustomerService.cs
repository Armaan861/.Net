using _14_Aug_2026.Models;

namespace _14_Aug_2026.Repository
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        Customer AddCustomer(Customer customer);
    }
}
