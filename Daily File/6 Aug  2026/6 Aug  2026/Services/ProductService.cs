using _6_Aug__2026.Data;
using _6_Aug__2026.Models;
using _6_Aug__2026.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace _6_Aug__2026.Services
//implement logic for CRUD operation on product entity by implementing IProductService interface
//service bussiness - logic
//dbContext - add , savechanges , find , tolist ,update , remove
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public List<Product> GetProducts()
        {
            return context.products.ToList(); // implementation of getproduct with help of TOList
        }

         public Product GetProductById(int id)
        {
            return context.products.Find(id); //
        }

         public void AddProduct(Product product)
        {
            context.products.Add(product); //implement of addition new roduct with help of add
            context.SaveChanges(); //saving new added [roduct in table
        }

         public void UpdateProduct(Product product)
        {
            context.products.Update(product); //implementation of 
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = context.products.Find(id);
            if(product == null)//Check product available
            
                context.products.Remove(product); // implement of remove existing product from table
                context.SaveChanges();//saving new  added product in detils of product table
            
        }

        
    }
}
