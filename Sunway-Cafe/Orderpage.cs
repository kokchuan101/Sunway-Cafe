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
            loadData();

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
                total += Convert.ToInt32(row.Cells["Price1"].Value) * Convert.ToInt32(row.Cells["Quantity1"].Value);
            }
            lbltotal.Text = $"{total * 1.16:0.00}";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            var quantity = (Convert.ToInt32(row.Cells[dataGridView1.Columns["Quantity1"].Index].Value));


            if (row.Cells["Product1"].Value != null)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Add1"].Index)
                {
                    quantity++;
                    row.Cells["Quantity1"].Value = quantity;
                    Total();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Deduct1"].Index)
                {
                    if (quantity > 0)
                    {
                        quantity--;
                        row.Cells["Quantity1"].Value = quantity;
                        Total();
                    }
                    else if (quantity < 1)
                    {
                        //remove current row that is 0
                        dataGridView1.Rows.Remove(row);
                        MessageBox.Show("Quantity is already at 0");
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Clear1"].Index)
                {
                    dataGridView1.Rows.Remove(row);
                    MessageBox.Show("Item is removed from the order");
                    Total();

                }

            }
        }
      
        private void Pay_Click_1(object sender, EventArgs e)
        {
            var order = new Order()
            {
                NetPrice = decimal.Parse(lbltotal.Text)/1.16M,
                TotalPrice = decimal.Parse(lbltotal.Text),
                Status = "Processing",
                DateTimeCreated = Global.ConvToDateTimeString(DateTime.Now),

            };

            using (var db = new SunwayCafeContext())
            {
                var lst = new List<OrderedItem>();
                //Add all item object from datagrid using id
                for (int i = 0; i < DataGridView1.Rows.Count - 1; i++)
                {
                    var id = Convert.ToInt32((dataGridView1.Rows[i].Cells[0].Value));
                    var item = db.Items.Where(x => x.Id == id).FirstOrDefault();
                    if (item == null)
                    {
                        MessageBox.Show("Unable to retrieve item from database", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lst.Add(new OrderedItem()
                        {
                            Order = order,
                            Item = item,
                            Qty = Convert.ToInt32((dataGridView1.Rows[i].Cells["Quantity1"].Value))
                        });
                    }
                }

                order.OrderedItems = lst;
                db.Orders.Add(order);
                db.SaveChanges();

            }

            var receiptItems = new List<ReceiptItem>();
            foreach (var item in order.OrderedItems)
            {
                receiptItems.Add(new ReceiptItem() { Qty = item.Qty, Name = item.Item.Name, UnitPrice = item.Item.SellingPrice });
            }

            var receipt = new Receipt() { Subtotal = order.NetPrice, ReceiptItems = receiptItems, Date = order.DateTimeCreated };

            var reportPage = new ReceiptPage(receipt);
            reportPage.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            i = 0;
          
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();


            string search = textBox1.Text.Trim();
            // Search items in our Jobs ListView, remove those that do not match search
            if (search != String.Empty)
            {
                using (var db = new SunwayCafeContext())
                {
                    //got two ToLower() is because need to allow upper case and lower case both acceptable by the search function
                    var query = db.Items.Where(d => d.Type == "food").ToList();

                    var query2 = from d in query
                                where d.Name.ToLower().StartsWith(search.ToLower())  
                                select d;

                    OrderOptions[] order = new OrderOptions[query2.Count()];


                    foreach (var itemList in query2)
                    {
                        order[i] = new OrderOptions(this);                      
                        order[i].Name_details = itemList.Name;
                        if (itemList.ImageURL != null)
                        {
                            order[i].displayImage = ConvertBinaryToImage(itemList.ImageURL);
                        }
                        order[i].WasClicked += OrderGrid_WasClicked;
                        order[i].Price = itemList.SellingPrice;
                        order[i].CostPrice = itemList.CostPrice;

                        flowLayoutPanel1.Controls.Add(order[i]);
                        i++;
                    }
                   

                   
                    var query3 = db.Items.Where(d => d.Type == "drinks").ToList();

                    var query4 = from d in query3
                                where d.Name.ToLower().StartsWith(search.ToLower())
                                select d;

                    OrderOptions[] order2 = new OrderOptions[query4.Count()];

                    foreach (var itemList in query4)
                    {
                        order2[i] = new OrderOptions(this);
                        order2[i].Name_details = itemList.Name;
                        if (itemList.ImageURL != null)
                        {
                            order2[i].displayImage = ConvertBinaryToImage(itemList.ImageURL);
                        }
                        order2[i].WasClicked += OrderGrid_WasClicked;
                        order2[i].Price = itemList.SellingPrice;
                        order2[i].CostPrice = itemList.CostPrice;

                        flowLayoutPanel2.Controls.Add(order2[i]);
                        i++;
                    }
                   

                }
                
            }
            else
            {
                loadData();
            }

        }
        public void loadData()
        {
            OrderOptions.selectItemName = null;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Remove(control);              
                control.Dispose();
            }
            foreach (Control control in flowLayoutPanel2.Controls)
            {              
                flowLayoutPanel2.Controls.Remove(control);
                control.Dispose();
            }

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            using (var db = new SunwayCafeContext())
            {
                var query = db.Items.Where(d => d.Type == "food").ToList();
                OrderOptions[] order = new OrderOptions[query.Count];

                foreach (var itemList in query)
                {
                    order[i] = new OrderOptions(this);
                    order[i].Name_details = itemList.Name;
                    order[i].ID = itemList.Id;
                    if (itemList.ImageURL != null)
                    {
                        order[i].displayImage = ConvertBinaryToImage(itemList.ImageURL);
                    }
                    order[i].Price = itemList.SellingPrice;
                    order[i].CostPrice = itemList.CostPrice;
                    order[i].WasClicked += OrderGrid_WasClicked;
                    flowLayoutPanel1.Controls.Add(order[i]);
                    i++;
                }
                i = 0;
            }

            using (var db = new SunwayCafeContext())
            {
                var query = db.Items.Where(d => d.Type == "drinks").ToList();
                OrderOptions[] order = new OrderOptions[query.Count];

                foreach (var itemList in query)
                {
                    order[i] = new OrderOptions(this);
                    order[i].ID = itemList.Id;
                    order[i].Name_details = itemList.Name;
                    if (itemList.ImageURL != null)
                    {
                        order[i].displayImage = ConvertBinaryToImage(itemList.ImageURL);
                    }
                    order[i].WasClicked += OrderGrid_WasClicked;
                    order[i].Price = itemList.SellingPrice;
                    order[i].CostPrice = itemList.CostPrice;

                    flowLayoutPanel2.Controls.Add(order[i]);
                    i++;
                }
                i = 0;
            }
        }

      
    }
}


