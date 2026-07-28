using _28_july_2026.Controllers.Models;

namespace _28_july_2026.Controllers.Services
{
    public class ProductServices : IProductServices
    {
        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Product1", Description = "Description1", Quantity = "10", Price = 100 },
            new Product { Id = 2, Name = "Product2", Description = "Description2", Quantity = "20", Price = 200 },
            new Product { Id = 3, Name = "Product3", Description = "Description3", Quantity = "30", Price = 300 }
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product? GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public Product? UpdateProduct(int id, Product product)
        {
            var existing = products.FirstOrDefault(p => p.Id == id);
            if (existing==  null)
                return null; 
            existing.Price = product.Price; 
            existing.Quantity = product.Quantity;
            return existing;
        }
        public bool DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id); 
            if (product==  null) return false; products.Remove(product);
            return true;

        }

       
    }
}
