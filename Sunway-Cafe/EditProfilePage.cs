using MetroSet_UI.Controls;
using Sunway_Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunway_Cafe
{
    public partial class EditProfilePage : Form
    {
        private Dictionary<string, MetroSetTextBox> textBoxs;
        public EditProfilePage()
        {
            InitializeComponent();
            //using (var db = new SunwayCafeContext())
            //{
            //    var query = db.Accounts.Where(acc => acc.Id == 1).Select(acc => new { acc.GivenName, acc.FamilyName, acc.Gender, acc.Contact, acc.Email, acc.Role }).ToList();

            //    familyName.Text = query[0].FamilyName;
            //    givenName.Text = query[0].GivenName;
            //    gender.Text = query[0].Gender;
            //    contact.Text = query[0].Contact.ToString();
            //    email.Text = query[0].Email;

            //}
            textBoxs = new Dictionary<string, MetroSetTextBox>()
            {
                { "FamilyName", familyName},
                { "GivenName", givenName},
                { "Gender", gender},
                { "Contact", contact},
                { "Email", email},
            };


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            
            var acc = new Account()
            {
                FamilyName = familyName.Text,
                GivenName = givenName.Text,
                Gender = gender.Text,
                Contact = int.Parse(contact.Text),
                Email = email.Text
            };

            List<List<string>> err;
            if (Global.IsValid<Account>(acc, out err))
            {
                MessageBox.Show("No Prob");
            }
            else
            {
                foreach (var er in err)
                {
                    errorProvider1.SetError(textBoxs[er[0]], er[1]);
                    textBoxs[er[0]].BorderColor = Color.Red;
                }
            }



            // using (var db = new SunwayCafeContext())
            //{
            //    var query = db.Accounts.Where(acc => acc.Id == 1).FirstOrDefault();

            //    query.FamilyName = familyName.Text;
            //    query.GivenName = givenName.Text;
            //    query.Gender = gender.Text ;
            //    query.Contact = int.Parse(contact.Text);
            //    query.Email = email.Text;
            //    db.SaveChanges();
            //}

            //Form profilePage = new ProfilePage();
            //profilePage.Refresh();
            //this.Close();
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
