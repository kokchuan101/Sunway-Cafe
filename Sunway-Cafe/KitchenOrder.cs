using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{
    public partial class KitchenOrder : UserControl
    {
        private KitchenPage kitchenPage;

        public KitchenOrder(IGrouping<int, dynamic> orderList, KitchenPage kitchenRef)
        {
            InitializeComponent();

            //Populate in orderId and items based on ordered items
            foreach (var order in orderList)
            {
                orderID.Text = order.OrderId.ToString();

                var item = new ListViewItem(order.Item.Name);
                item.SubItems.Add(order.Qty.ToString());
                listView1.Items.Add(item);
            }
            kitchenPage = kitchenRef;



        }

        private void MetroSetButton1_Click(object sender, EventArgs e)
        {
            using(var db = new SunwayCafeContext())
            {
                var id = int.Parse(orderID.Text);
                var query = db.OrderedItems.Where(x => x.OrderId == id).Select(x => x.Order).FirstOrDefault();
                query.Status = "Closed";
                query.DateTimeClosed = Global.ConvToDateTimeString(DateTime.Now);
                db.SaveChanges();
            }
            kitchenPage.RefreshKitchenOrder();
        }
    }
}
