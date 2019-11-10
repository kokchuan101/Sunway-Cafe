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
        public ItemPage()
        {
            InitializeComponent();
        }

        public static ItemPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ItemPage();
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateItem create = new CreateItem();
            create.Show();
        }

      
        private void load_Click(object sender, EventArgs e)
        {
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
                    flowLayoutPanel1.Controls.Add(order[i]);     
                    i++;
                }
                i = 0;
            }
            
        }

        private void OrderGrid_WasClicked(object sender,EventArgs e)
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

        private void delete_Click(object sender, EventArgs e)
        {
            using (var db = new SunwayCafeContext())
            {

                ItemTests itemDelete = new ItemTests();
                db.ItemTestss.Attach(itemDelete);
                db.ItemTestss.Remove(itemDelete);
                db.SaveChanges();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
