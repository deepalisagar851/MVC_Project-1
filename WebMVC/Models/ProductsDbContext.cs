using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class ProductsDbContext:DbContext
    {
        public ProductsDbContext() : base("Data Source=CHETUIWK428\\SQLEXPRESS;" +
            "Initial Catalog=DbInfo;Integrated Security=True;Pooling=False") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}