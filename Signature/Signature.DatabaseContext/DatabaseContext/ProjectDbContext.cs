using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Signature.Model.Model;

namespace Signature.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Customer> Customers { get; set; }
        public  DbSet<Supplier> Suppliers { set; get; }
    }
}
