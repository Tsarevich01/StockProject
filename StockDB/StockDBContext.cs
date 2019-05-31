using StockProject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public virtual DbSet<Person> Persons{ get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Component> Component { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        //public virtual DbSet<Selling> Sellings { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        //public virtual DbSet<StockComponent> StockComponents { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        //public virtual DbSet<ProductComponent> ProductComponents { get; set; }
    }
}
