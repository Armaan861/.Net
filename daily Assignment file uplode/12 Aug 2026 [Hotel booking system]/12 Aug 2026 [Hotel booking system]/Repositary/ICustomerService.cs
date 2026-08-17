using _12_Aug_2026__Hotel_booking_system_.Models;

namespace _12_Aug_2026__Hotel_booking_system_.Repositary
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetById(int id);
        Customer AddCustomer(Customer customer);

    }
}
