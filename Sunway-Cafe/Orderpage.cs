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
using System.IO;


namespace Sunway_Cafe
{
    public partial class OrderPage : UserControl
    {

        DataTable dataTable = new DataTable();
        private static OrderPage _instance;
        int i = 0;

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
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            flowLayoutPanel1.Controls.Clear();

            using (var db = new SunwayCafeContext())
            {
                var query = db.ItemTestss.ToList();
                OrderOptions[] order = new OrderOptions[query.Count];

                foreach (var itemList in query)
                {
                    order[i] = new OrderOptions();
                    order[i].Name_details = itemList.Name;
                    order[i].displayImage = ConvertBinaryToImage(itemList.ImageURL);
                    order[i].WasClicked += OrderGrid_WasClicked;
                    order[i].Price = itemList.Price;
                    order[i].QTY = itemList.Quantity;
                    flowLayoutPanel1.Controls.Add(order[i]);
                    i++;
                }
                i = 0;
            }

        }

        private void OrderGrid_WasClicked(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is OrderOptions)
                {
                    ((OrderOptions)c).IsSelected = false;
                }
            }
        }

        Image ConvertBinaryToImage(byte[] image)
        {
            using (MemoryStream ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

   

        private void AddOrder_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(OrderOptions.selectItemName,"Add",1,"Deduct",OrderOptions.selectedItemPrice);
        }
      
    }
}
