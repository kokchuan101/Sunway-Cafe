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

        public ProfilePage()
        {
            InitializeComponent();
            RefreshPage();
        }

        public void RefreshPage()
        {
            position.Text = Global.user.Details.Role;
            familyName.Text = Global.user.Details.FamilyName;
            givenName.Text = Global.user.Details.GivenName;
            gender.Text = Global.user.Details.Gender;
            contact.Text = Global.user.Details.Contact.ToString();
            email.Text = Global.user.Details.Email;
        }



        private void editProfile_Click_1(object sender, EventArgs e)
        {
            //EditProfilePage editProfile = new EditProfilePage();
            //editProfile.ShowDialog();
            //this.Refresh();
            EditProfilePage editProfile = new EditProfilePage(Global.user.Details, this); //create new isntance of form
            editProfile.FormClosed += new FormClosedEventHandler(EditProfilePage_FormClosed); //add handler to catch when child form is closed
            editProfile.Show(); //show child
        }

        private void EditProfilePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.InitializeComponent();
        }
    }
}
