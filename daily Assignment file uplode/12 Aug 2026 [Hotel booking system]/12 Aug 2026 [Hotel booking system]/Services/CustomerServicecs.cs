using _12_Aug_2026__Hotel_booking_system_.Data;
using _12_Aug_2026__Hotel_booking_system_.Models;
using _12_Aug_2026__Hotel_booking_system_.Repositary;

namespace _12_Aug_2026__Hotel_booking_system_.Services
{
    public class CustomerService :ICustomerService
    {
        private readonly AppDbContext context;
        public CustomerService(AppDbContext context)
        {
            this.context = context;
        }

        public Customer AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public Customer GetById(int id)
        {
            return context.Customers.Find(id);
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();        }
    }
}
