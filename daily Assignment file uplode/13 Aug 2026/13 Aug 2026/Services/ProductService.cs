using _13_Aug_2026.Data;
using _13_Aug_2026.Model;
using _13_Aug_2026.Repositary;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace _13_Aug_2026.Services
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

        public void DeleteProduct(int id)
        {
            var exesting = context.Products.Find(id);
            if (exesting == null)
            {
                return;
            }
            context.Products.Remove(exesting);
            context.SaveChanges();
            return;
        }

        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }
}
