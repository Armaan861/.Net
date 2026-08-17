using _13_Aug_2026.Model;

namespace _13_Aug_2026.Repositary
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetById(int id);
        Product AddProduct(Product product);
        void DeleteProduct(int id);

    }   
}
