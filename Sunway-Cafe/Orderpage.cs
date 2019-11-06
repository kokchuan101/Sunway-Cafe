using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sunway_Cafe
{
    public partial class OrderPage : UserControl
    {
       
        private static OrderPage _instance;

        public static OrderPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OrderPage();
                return _instance;
            }
        }
        public OrderPage()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            using (var db = new SunwayCafeContext())
            {
                var query = db.ItemTestss.ToList();

                foreach (var itemList in query)
                {

                    ListViewItem item = new ListViewItem(itemList.ID.ToString());
                    item.SubItems.Add(itemList.Name);

                    listView1.Items.Add(item);
                  
                }

            }



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            MoveToOrder(listView1, listView2);
        }

        private static void MoveToOrder(ListView listView1, ListView listView2)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView2.Items.Add((ListViewItem)item.Clone());
            }
        }
    }
}
