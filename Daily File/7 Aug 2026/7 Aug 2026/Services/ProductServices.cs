using _7_Aug_2026.Data;
using _7_Aug_2026.Models;
using _7_Aug_2026.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace _7_Aug_2026.Services
{
    public class ProductServices : IProductService
    {
        private readonly AppDbContext context;

        public ProductServices(AppDbContext context)
        {
            this.context = context;
        }
        public Product? AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }        

        public Product? GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }
}
