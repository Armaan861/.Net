
using _6_Aug__2026.Models;
using Microsoft.EntityFrameworkCore;

namespace _6_Aug__2026.Data
{ // manages the application database conection
    public class AppDbContext : DbContext
    {  //contructor accept configuration option  and passes them to base class 
        // ensure proper db provider and connection string setup
      
        
            // Define your DbSet properties for your entities here
            // Example:
            // public DbSet<Product> Products { get; set; }

            public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

        //maps prduct entity class to  corresponding db tables 
        // query , save data 

            public DbSet<Product>products {  get; set; }
        }
    }

