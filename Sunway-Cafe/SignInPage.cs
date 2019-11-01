using Sunway_Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunway_Cafe
{
    public partial class SignInPage : Form
    {
        
        public SignInPage()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;

            //using(var db = new SunwayCafeContext())
            //{
            //    db.Items.Add(new Item() { Name = "Shit pie", Type = "food", CostPrice = 5.00M, SellingPrice = 2.00M });
            //    db.SaveChanges();

            //    var query = db.Items.ToList();
            //    Console.WriteLine("done");

            //}

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            AccountPage account = new AccountPage();
            account.Show();
            Hide();
        }
    }
}
