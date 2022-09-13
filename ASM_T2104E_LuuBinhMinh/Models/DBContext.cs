using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASM_T2104E_LuuBinhMinh.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DBASM")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DBContext(DbSet<Product> products, DbSet<Category> categories)
        {
            Products = products;
            Categories = categories;
        }
    }
}