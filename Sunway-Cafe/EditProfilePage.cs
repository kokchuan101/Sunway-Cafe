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
    public partial class EditProfilePage : Form
    {
        public EditProfilePage()
        {
            InitializeComponent();
            using (var db = new SunwayCafeContext())
            {
                var query = db.Accounts.Where(acc => acc.Id == 1).Select(acc => new { acc.GivenName, acc.FamilyName, acc.Gender, acc.Contact, acc.Email, acc.Role }).ToList();

                familyName.Text = query[0].FamilyName;
                givenName.Text = query[0].GivenName;
                gender.Text = query[0].Gender;
                contact.Text = query[0].Contact.ToString();
                email.Text = query[0].Email;

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            using (var db = new SunwayCafeContext())
            {
                var query = db.Accounts.Where(acc => acc.Id == 1).FirstOrDefault();

                query.FamilyName = familyName.Text;
                query.GivenName = givenName.Text;
                query.Gender = gender.Text ;
                query.Contact = int.Parse(contact.Text);
                query.Email = email.Text;
                db.SaveChanges();
            }

            Form profilePage = new ProfilePage();
            profilePage.Refresh();
            this.Close();
            
        }
    }
}
