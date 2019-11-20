
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Exit();
            Application.Run(new MainPage());
            //Application.Run(new SignInPage());
            //Application.Run(new ReportTest());

            //using (var db = new SunwayCafeContext())
            //{
            //    var query = db.OrderedItems.Select(it => new { it.OrderId, it.Qty, it.Item }).GroupBy(it => it.OrderId).ToList();
            //    var items = query[4];
            //    foreach(var it in items)
            //    {
            //        var m = it.Item.Name;
            //    }
                
            //    var query2 = db.OrderedItems.Where(it => it.OrderId == 1).Select(it => new { it.Qty, it.Item }).ToList();
            //    Console.WriteLine();
            //}

        }
    }
    
    
}
