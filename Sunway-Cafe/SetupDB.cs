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
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }
        public DbSet<ItemTests> ItemTestss { get; set; }

    }

    public class SunwayCafeContextInitializer : SqliteCreateDatabaseIfNotExists<SunwayCafeContext>
    {
        public SunwayCafeContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(SunwayCafeContext context)
        {
            context.Set<Item>().Add(new Item() { Name = "apple pie", Type = "food", CostPrice = 5.00M, SellingPrice = 2.00M });
            context.Set<Item>().Add(new Item() { Name = "Banana Pie", Type = "food", CostPrice = 5.00M, SellingPrice = 2.00M });
            context.Set<Account>().Add(new Account() { Id = 1, Username = "food", Password = "abc", GivenName = "Mu", FamilyName = "Cheng", Gender = "Female", Contact = 130401404, Email = "mucheng@yourheart.com", Role = "Eat, Sleep, Apex, Repeat!!" });
            //context.Set<Stock>().Add(new Stock() { Name = "Apple Pie"}); 

        }

    }

    //using (var db = new SunwayCafeContext())
    //{
    //    var query = db.Accounts.ToList();
    //    var account = new Account()
    //    {
    //        Id = 1,
    //        Username = "lmao",
    //        Password = "abc",
    //        GivenName = "mu",
    //        FamilyName = "cheng",
    //        Gender = "prefer not to disclose",
    //        Contact = 0123456789,
    //        Email = "mucheng@yourheart.com.my",
    //        Role = "eat, sleep, apex, repeat"
    //    };

    //}
   

    //using (var db = new SunwayCafeContext())
    //{
    //    var query = db.Items.ToList();
    //    var order = new Order()
    //    {
    //        NetPrice = 10.00M,
    //        TotalPrice = 12.00M,
    //        Status = "Open",
    //        DateTimeCreated = "Now",

    //    };

    //    var lst = new List<OrderedItem>();

    //    foreach (var item in query)
    //    {
    //        lst.Add(new OrderedItem()
    //        {
    //            Order = order,
    //            Item = item,
    //            Qty = 20
    //        });
    //    }

    //    order.OrderedItems = lst;
    //    db.Orders.Add(order);
    //    db.SaveChanges();

    //    var query2 = db.OrderedItems.Where(it => it.OrderId == 1).Select(it => new { it.Qty, it.Item }).ToList();

    //}
}
