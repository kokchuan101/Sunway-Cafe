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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            position.Text = "Eat, Play, Sleep, Repeat";
            familyName.Text = "Chan";
            givenName.Text = "Onee";
            gender.Text = "Prefer not to disclose";
            contact.Text = "911";
            email.Text = "mucheng@yourheart.com.my";
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
        }

    }
}
