using Microsoft.EntityFrameworkCore;
using StoreWepApp.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.Model.DBContext
{
    public class StoreDBConext:DbContext
    {
        public StoreDBConext(DbContextOptions<StoreDBConext> options) : base(options)
        {
        }
        public DbSet<Product>? Product { get; set; } = null;

    }
}

