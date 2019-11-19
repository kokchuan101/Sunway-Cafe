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
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{
    public partial class OrderPage : UserControl
    { 
        public DataGridView DataGridView1
        {
            get
            {
                return dataGridView1;
            }
            set
            {
                dataGridView1 = value;
            }
        }

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
                    order[i] = new OrderOptions(this);
                    order[i].Name_details = itemList.Name;
                    if (itemList.ImageURL != null)
                    {
                        order[i].displayImage = ConvertBinaryToImage(itemList.ImageURL);
                    }
                    order[i].WasClicked += OrderGrid_WasClicked;
                    order[i].Price = itemList.Price;
                    
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

        public void Total()
        {
            var total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {              
                total += Convert.ToInt32(row.Cells["Price"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value);              
            }
            lbltotal.Text = total.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            var quantity = (Convert.ToInt32(row.Cells[dataGridView1.Columns["Quantity"].Index].Value));


            if (row.Cells["Product"].Value != null)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Add"].Index)
                {
                    quantity++;
                    row.Cells["Quantity"].Value = quantity;
                    Total();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Deduct"].Index)
                {                   
                    if (quantity > 0)
                    {
                        quantity--;
                        row.Cells["Quantity"].Value = quantity;
                        Total();
                    }
                    else if (quantity < 1)
                    {
                        //remove current row that is 0
                        dataGridView1.Rows.Remove(row);
                        MessageBox.Show("Quantity is already at 0");
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Clear"].Index)
                {
                    dataGridView1.Rows.Remove(row);
                    MessageBox.Show("Item is removed from the order");
                    Total();

                }
                
            }
        }

        //Retrieve data from datagridview
        private void Retrieve_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridView1.Rows.Count-1; i++)
            {
                //Count-2 cause last two column is not needed
                for (int j = 0; j < dataGridView1.Columns.Count-3; j++)
                {
                    MessageBox.Show(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
        }
    }
}
