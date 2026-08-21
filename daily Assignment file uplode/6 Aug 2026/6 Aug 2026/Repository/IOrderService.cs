using _6_Aug_2026.Models;
namespace _6_Aug_2026.Repository
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);

    }
}
