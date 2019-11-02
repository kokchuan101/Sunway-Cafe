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

    public partial class ProfilePage : Form
    {
        Account account = new Account();

        public ProfilePage()
        {
            InitializeComponent();

            position.Text = account.Role;
            familyName.Text = account.FamilyName;
            givenName.Text = account.GivenName;
            gender.Text = account.Gender;
            contact.Text = account.Contact.ToString();
            email.Text = account.Email;
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            EditProfilePage editProfile = new EditProfilePage();
            editProfile.Show();
        }

    }
}
