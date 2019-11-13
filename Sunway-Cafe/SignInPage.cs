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
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
            try
            {
                using (var db = new SunwayCafeContext())
                {
                    db.Accounts.ToList();
                }
            }
            catch (InvalidCastException ice)
            {
                if (ice == null)
                {
                    MessageBox.Show("Null Value Detected");
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SunwayCafeContext())
                {
                    var query = db.Accounts.Where(acc => acc.Username == username.Text && acc.Password == password.Text).FirstOrDefault();
                    if (query != null)
                    {
                        if (query.Role == "Admin")
                        {
                            Global.user = new Admin(query);
                        }
                        else
                        {
                            Global.user = new SalesStaff(query);
                        }
                        AccountPage account = new AccountPage();
                        account.Show();

                        this.Hide();
                        //MessageBox.Show($"{Global.user.Details.GivenName} and {Global.user.Details.Role}");


                    }
                    else
                    {
                        
                    }

                }
            }
            catch (InvalidCastException ice)
            {
                if (ice == null)
                {
                    MessageBox.Show("Null Value Detected");
                }
            }
            
            
        }
    }
}
