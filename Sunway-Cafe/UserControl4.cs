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
    public partial class UserControl4 : UserControl
    {
        private static UserControl4 _instance;
        public UserControl4()
        {
            InitializeComponent();
        }

        public static UserControl4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl4();
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
            listView1.Items.Clear();
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

        private void delete_Click(object sender, EventArgs e)
        {
            using (var db = new SunwayCafeContext())
            {

                ItemTests itemDelete = new ItemTests { ID = 1 };
                db.ItemTestss.Attach(itemDelete);
                db.ItemTestss.Remove(itemDelete);
                db.SaveChanges();
            }
        }
    }
}
