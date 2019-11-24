using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sunway_Cafe
{
    public partial class KitchenPage : UserControl
    {

        public KitchenPage()
        {
            InitializeComponent();
            RefreshKitchenOrder();

            //var thread = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        RefreshKitchenOrder();
            //        Thread.Sleep(2000);
            //    }
            //});
            //thread.IsBackground = true;
            //thread.Start();
        }


        public void RefreshKitchenOrder()
        {

            //foreach (Control control in flowLayoutPanel1.Controls)
            //{
            //    if (this.InvokeRequired)
            //    {
            //        Invoke(new MethodInvoker(() => 
            //        {
            //            flowLayoutPanel1.Controls.Clear();
            //            control.Dispose();
            //        }));
            //    }
            //    else
            //    {
            //        flowLayoutPanel1.Controls.Remove(control);
            //        control.Dispose();
            //    }
                    
            //}
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(() => flowLayoutPanel1.Controls.Clear()));
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
            }
            
            using (var db = new SunwayCafeContext())
            {
                //Get orders with "Processing" status and populate in flowlayout
                var orders = db.OrderedItems.Where(x => x.Order.Status == "Processing").Select(it => new { it.OrderId, it.Qty, it.Item }).GroupBy(x => x.OrderId).ToList();
                foreach(var order in orders)
                {
                    var kitchenOrder = new KitchenOrder(order, this);
                    if(this.InvokeRequired)
                    {
                        Invoke(new MethodInvoker(() => flowLayoutPanel1.Controls.Add(kitchenOrder)));
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(kitchenOrder);

                    }
                }
            }
        }


    }
}
