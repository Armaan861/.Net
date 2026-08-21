using _7_Aug_2026.Data;
using _7_Aug_2026.Models;
using _7_Aug_2026.Repository;
using Microsoft.EntityFrameworkCore;

namespace _7_Aug_2026.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext context;

        public OrderService(AppDbContext context)
        {
            this.context=  context;
        }
        public List<Orders> GetOrders()
        {
            return context.Orders.Include(o =>o.OrderItems!).ThenInclude(i => i.product).ToList();
        }
    }
}
