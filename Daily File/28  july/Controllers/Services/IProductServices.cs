using _28_july_2026.Controllers.Models;

namespace _28_july_2026.Controllers.Services
{
    public interface IProductServices
    {
        List<Product> GetAll();
        
        Product? GetById(int id);
        Product AddProduct(Product product);
        Product? UpdateProduct(int id, Product product);
        bool DeleteProduct(int id);
    }
}
