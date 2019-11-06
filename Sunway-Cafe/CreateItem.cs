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
    public partial class CreateItem : Form
    {

        ItemTests test = new ItemTests();
        public CreateItem()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            test.Name = textBox2.Text.Trim();
            using (var db = new SunwayCafeContext())
            {
                db.ItemTestss.Add(test);
                db.SaveChanges();
            }
            MessageBox.Show("Item Created");
           
        }
    }
}
