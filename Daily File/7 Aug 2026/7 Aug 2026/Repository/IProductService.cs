using _7_Aug_2026.Models;

namespace _7_Aug_2026.Repository
{
    public interface IProductService
    {

        //define what operation are available
        
            List<Product> GetProducts();
            Product? GetProductById(int id);
            Product? AddProduct(Product product);
    }

}

