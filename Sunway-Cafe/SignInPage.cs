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
        private int failure = 0; 
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
                    MessageBox.Show("Unable to retrieve item from database", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            using(var db = new SunwayCafeContext())
            {
                var order = db.Orders.Where(x => x.Status == "Processing").FirstOrDefault();
                if(order == null)
                {
                    var form = new BusinessReportPage();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Unable to close application. There is some orders still being processed. Please check Kitchen Page.", "Outstanding Orders", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
                        MainPage form1 = new MainPage();
                        form1.Show();

                        this.Hide();
                        
                    }
                    else
                    {
                        failure++;
                        if(failure == 5)
                        {
                            MessageBox.Show("Terminating program due to 5 consecutive invalid credentials. ", "Auto Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            catch (InvalidCastException ice)
            {
                if (ice == null)
                {
                    MessageBox.Show("Unable to retrieve item from database", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }
    }
}
