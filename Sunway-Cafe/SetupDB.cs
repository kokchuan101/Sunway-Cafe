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
        public DbSet<Item> Items { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Model.Account> Accounts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

    public class SunwayCafeContextInitializer : SqliteDropCreateDatabaseAlways<SunwayCafeContext>
    {
        public SunwayCafeContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(SunwayCafeContext context)
        {
            context.Set<Item>().Add(new Item() { Name = "apple pie", Type = "food", CostPrice = 5.00M, SellingPrice = 2.00M });
            context.Set<Item>().Add(new Item() { Name = "Banana Pie", Type = "food", CostPrice = 5.00M, SellingPrice = 2.00M });
            //context.Set<Stock>().Add(new Stock() { Name = "Apple Pie"});
        }
    }
}
