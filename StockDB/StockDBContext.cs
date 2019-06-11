﻿using StockProject;
using System.Data.Entity;

namespace StockDB
{
    public class StockDBContext : DbContext
    {
        public StockDBContext() : base("StockDatabase")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public  DbSet<User> Users{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Component> Component { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        //public virtual DbSet<Selling> Sellings { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        //public virtual DbSet<StockComponent> StockComponents { get; set; }
        public DbSet<Unit> Units { get; set; }
        //public virtual DbSet<ProductComponent> ProductComponents { get; set; }
    }
}
