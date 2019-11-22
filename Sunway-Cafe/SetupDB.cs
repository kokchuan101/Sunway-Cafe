using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunway_Cafe.Model;
using System.IO;
using System.Drawing;

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

        //       public DbSet<OrderTests> OrderTests { get; set; }
    }

    public class SunwayCafeContextInitializer : SqliteCreateDatabaseIfNotExists<SunwayCafeContext>
    {
        public SunwayCafeContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(SunwayCafeContext context)
        {           
            context.Set<Account>().Add(new Account() { Username = "test1", Password = "test1", GivenName = "Mu", FamilyName = "Cheng", Gender = "Female", Contact = "130401404", Email = "mucheng@yourheart.com", Role = "Admin" });
            context.Set<Account>().Add(new Account() { Username = "adminuser1", Password = "adminuser1", GivenName = "Mu", FamilyName = "Cheng", Gender = "Female", Contact = "130401404", Email = "mucheng@yourheart.com", Role = "Admin" });
            context.Set<Account>().Add(new Account() { Username = "saleuser1", Password = "saleuser1", GivenName = "Mu", FamilyName = "Cheng", Gender = "Female", Contact = "130401404", Email = "mucheng@yourheart.com", Role = "SalesStaff" });
            context.Set<Account>().Add(new Account() { Username = "saleuser2", Password = "saleuser2", GivenName = "Mu", FamilyName = "Cheng 2.0", Gender = "Female", Contact = "130401404", Email = "mucheng@yourheart.com", Role = "SalesStaff" });

            Image img = Properties.Resources.banana;
            Image img2 = Properties.Resources.Korean_Burger;
            Image img3 = Properties.Resources.Ice_Lemon_Water;       
            context.Set<Item>().Add(new Item() { Name = "Korean Burger", Type = "food", CostPrice = 7.00M, SellingPrice = 15.00M, ImageURL = Global.ConvertImageToBinary(img2)});
            context.Set<Item>().Add(new Item() { Name = "Banana Pie", Type = "food", CostPrice = 5.00M, SellingPrice = 2.00M, ImageURL = Global.ConvertImageToBinary(img)});
            context.Set<Item>().Add(new Item() { Name = "iced Lemon Water", Type = "drinks", CostPrice = 1.50M, SellingPrice = 2.50M, ImageURL = Global.ConvertImageToBinary(img3)});

            //hardcode order
            context.Set<Order>().Add(new Order() { NetPrice = 6, TotalPrice = 12, Status = "Processing", DateTimeCreated = "DK", DateTimeClosed = "DK2" });
            context.Set<Order>().Add(new Order() { NetPrice = 6, TotalPrice = 12, Status = "Processing", DateTimeCreated = "DK", DateTimeClosed = "DK2" });
            context.Set<Order>().Add(new Order() { NetPrice = 6, TotalPrice = 12, Status = "Processing", DateTimeCreated = "DK", DateTimeClosed = "DK2" });
            context.Set<Order>().Add(new Order() { NetPrice = 6, TotalPrice = 12, Status = "Processing", DateTimeCreated = "DK", DateTimeClosed = "DK2" });
            context.Set<Order>().Add(new Order() { NetPrice = 6, TotalPrice = 12, Status = "Processing", DateTimeCreated = "DK", DateTimeClosed = "DK2" });

            context.Set<OrderedItem>().Add(new OrderedItem() { OrderId = 1, ItemId = 1, Qty = 2 });
            context.Set<OrderedItem>().Add(new OrderedItem() { OrderId = 2, ItemId = 1, Qty = 2 });
            context.Set<OrderedItem>().Add(new OrderedItem() { OrderId = 3, ItemId = 1, Qty = 2 });
            context.Set<OrderedItem>().Add(new OrderedItem() { OrderId = 4, ItemId = 1, Qty = 2 });
            context.Set<OrderedItem>().Add(new OrderedItem() { OrderId = 5, ItemId = 1, Qty = 2 });


            context.Set<Stock>().Add(new Stock() { Name = "Salt", Type = "Spice", Qty = "10", Unit = "Grams", CriticalLevel = "2"});
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
