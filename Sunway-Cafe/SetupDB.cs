using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{
    public class SunwayCafeContext : DbContext
    {
        public SunwayCafeContext() : base("name=SunwayCafe") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SunwayCafeContextInitializer(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        
    }

    public class SunwayCafeContextInitializer : SqliteDropCreateDatabaseAlways<SunwayCafeContext>
    {
        public SunwayCafeContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(SunwayCafeContext context)
        {
            //context.Set<Item>().Add(new Item() { Name="Apple Pie", Type="Food", CostPrice=5.00M, SellingPrice=2.00M});
        }
    }
}
