using _13_Aug_2026.Model;

namespace _13_Aug_2026.Repositary
{
    public interface ICustomerService
    {
        Customer Register(Customer customer);
        Customer? GetCustomerByEmail(string email);
    }
}
