using _14_Aug_2026.Data;
using _14_Aug_2026.Models;
using _14_Aug_2026.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace _14_Aug_2026.Services
{
    public class ProductService : IProductService
    {


        private readonly AppDbContext context;
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public Product AddProduct(Product product)
        {
            
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public Product GetProductById(int id)
        {
            return context.Products.Find(id);

        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public Product UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
