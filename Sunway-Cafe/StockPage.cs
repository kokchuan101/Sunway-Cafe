using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunway_Cafe.Model;


namespace Sunway_Cafe
{
    public partial class StockPage : Form
    {
        public StockPage()
        {
            InitializeComponent();
            RefreshListView();
        }

        private void create_Click(object sender, EventArgs e)
        {
            StockCreate sc = new StockCreate(null, this);
            sc.Show();
        }

        public void RefreshListView()
        {
            listView1.Items.Clear();
            try
            {
                using (var db = new SunwayCafeContext())
                {

                    var query = db.Stocks.ToList();

                    foreach (var stocklist in query)
                    {
                        ListViewItem stock = new ListViewItem(stocklist.Id.ToString());
                        stock.SubItems.Add(stocklist.Name);
                        stock.SubItems.Add(stocklist.Type);
                        stock.SubItems.Add(stocklist.Qty);
                        stock.SubItems.Add(stocklist.Unit);
                        stock.SubItems.Add(stocklist.CriticalLevel);

                        listView1.Items.Add(stock);
                    }

                }
                listView1.Items[0].Selected = true;
                listView1.Select();
            }
            catch (InvalidCastException ice)
            {
                if (ice == null)
                {
                    MessageBox.Show("Unable to retrieve item from database", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SunwayCafeContext())
                    {
                        ListViewItem item = listView1.SelectedItems[0];
                        var id = int.Parse(item.Text);
                        var selected = db.Stocks.Where(acc => acc.Id == id).FirstOrDefault();
                        db.Stocks.Remove(selected);
                        db.SaveChanges();
                    }
                }
                catch (InvalidCastException ice)
                {
                    if (ice == null)
                    {
                        MessageBox.Show("Unable to retrieve item from database", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefreshListView();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            var id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            using (var db = new SunwayCafeContext())
            {
                var stock = db.Stocks.Where(x => x.Id == id).FirstOrDefault();
                if (stock != null)
                {
                    StockCreate sc = new StockCreate(stock, this);
                    sc.Show();
                }
                else
                {
                    MessageBox.Show("Unable to retrieve item from database", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshListView();
        }

        private void load_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
