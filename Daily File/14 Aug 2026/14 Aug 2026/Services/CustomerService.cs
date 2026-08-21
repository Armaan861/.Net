using _14_Aug_2026.Data;
using _14_Aug_2026.Models;
using _14_Aug_2026.Repository;

namespace _14_Aug_2026.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly AppDbContext context;
        public CustomerService (AppDbContext context)
        {
            this.context = context;
        }

        public Customer AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
    }
}
