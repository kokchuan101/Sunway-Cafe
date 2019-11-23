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
using System.IO;

namespace Sunway_Cafe
{
    public partial class ItemPage : UserControl
    {
        private static ItemPage _instance;


        int i = 0;
        public static string selectedName;


        public ItemPage()
        {
            InitializeComponent();
            OrderOptions.selectItemName = null;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            flowLayoutPanel1.Controls.Clear();

            using (var db = new SunwayCafeContext())
            {
                var query = db.Items.ToList();
                OrderOptions[] order = new OrderOptions[query.Count];

                foreach (var itemList in query)
                {
                    order[i] = new OrderOptions(this);
                    order[i].Name_details = itemList.Name;
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
        }

       
        private void create_Click(object sender, EventArgs e)
        {
            CreateItem create = new CreateItem(null);
            create.Show();
        }


        private void load_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            OrderOptions.selectItemName = null;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            flowLayoutPanel1.Controls.Clear();

            using (var db = new SunwayCafeContext())
            {
                var query = db.Items.ToList();
                OrderOptions[] order = new OrderOptions[query.Count];

                foreach (var itemList in query)
                {
                    order[i] = new OrderOptions(this);
                    order[i].Name_details = itemList.Name;
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

        Control foundControl = null;

        private void delete_Click_1(object sender, EventArgs e)
        {
           if (OrderOptions.selectItemName != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {               
                        using (var db = new SunwayCafeContext())
                        {
                            var query = db.Items.ToList();
                            OrderOptions[] order = new OrderOptions[query.Count];
                            Item delItem;

                            foreach (Control c in flowLayoutPanel1.Controls)
                            {
                                if (((OrderOptions)c).IsSelected == true)
                                {
                                    foreach (var itemList in query)
                                    {
                                        foundControl = c;
                                        break;
                                    }
                                }
                            }


                            if (foundControl != null)
                            {
                                foreach (var itemList in query)
                                {
                                    if (OrderOptions.selectItemName == itemList.Name)
                                    {
                                        MessageBox.Show(itemList.Name + " is deleted from database. Reload the page");
                                        delItem = db.Items.Where(d => d.Name == OrderOptions.selectItemName).First();
                                        db.Items.Remove(delItem);
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OrderOptions.selectItemName = null;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            flowLayoutPanel1.Controls.Clear();


            string search = textBox1.Text.Trim();
            // Search items in our Jobs ListView, remove those that do not match search
            if (search != String.Empty)
            {
                using (var db = new SunwayCafeContext())
                {
                    // got two ToLower() is because need to allow upper case and lower case both acceptable by the search function
                    var query = from d in db.Items
                                where d.Name.ToLower().StartsWith(search.ToLower())
                                select d;
                    OrderOptions[] order = new OrderOptions[query.Count()];

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

                        flowLayoutPanel1.Controls.Add(order[i]);
                        i++;
                    }
                    i = 0;
                }
            }
            else
            {
                loadData();
            }
        }
    }
}
