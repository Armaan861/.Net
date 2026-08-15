using _14_Aug_2026.Models;

namespace _14_Aug_2026.Repository
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        Product AddProduct(Product product);
        Product UpdateProduct(int id, Product product);
    }
}
