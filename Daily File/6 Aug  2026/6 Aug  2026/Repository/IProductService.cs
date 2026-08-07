using _6_Aug__2026.Models;

namespace _6_Aug__2026.Repository
{
    //define all CRUD( create , read, update, delete) method for performing  on product entity
    public interface IProductService
    {
        List<Product> GetProducts(); //feth all product from product table
        Product GetProductById(int id); //fetch product by id from product table based on Pid
        void AddProduct(Product product); //add new product record to product table
        void UpdateProduct(Product product); //update existing product record in product PId
        void DeleteProduct(int id); //delete product record from product table based on Pid
    }
}
