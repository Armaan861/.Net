using _6_Aug_2026.Data;
using _6_Aug_2026.Models;
using _6_Aug_2026.Repository;

namespace _6_Aug_2026.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext context;
        public OrderService(AppDbContext context)
        {
            this.context = context;
        }
        public List<Order> GetAllOrders()
        {
            return context.orders.ToList();
        }

        public Order GetById(int id)
        {
            return context.orders.Find(id);
        }

        public void AddOrder(Order order)
        {
            context.orders.Add(order);
            context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = context.orders.Find(id);

            if (order == null)
                return;

            context.orders.Remove(order);
            context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            context.orders.Update(order); //implementation of 
            context.SaveChanges();
        }


    }
}
