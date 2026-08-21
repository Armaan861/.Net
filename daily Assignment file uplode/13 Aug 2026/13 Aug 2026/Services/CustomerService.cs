using _13_Aug_2026.Data;
using _13_Aug_2026.Model;
using _13_Aug_2026.Repositary;
using Microsoft.EntityFrameworkCore;

namespace _13_Aug_2026.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext context;
        public CustomerService(AppDbContext context)
        {
            this.context = context;
        }
        public Customer? GetCustomerByEmail(string email)
        {
            return context.Customers.FirstOrDefault(c => c.Email == email);
        }

        public Customer Register(Customer customer)
        {
            customer.Role = "Customer";

            context.Customers.Add(customer);
            context.SaveChanges();

            return customer;
        }
    }
}
