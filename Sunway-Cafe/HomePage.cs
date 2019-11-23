using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunway_Cafe
{
    public partial class HomePage : UserControl
    {
        public Button Account { get => account; set => account = value; }
        public Button Item { get => item; set => item = value; }
        public Button Stock { get => stock; set => stock = value; }
        public HomePage()
        {
            InitializeComponent();
            Global.user.ModifyHomeDisplay(this);

        }

        private void Order_Click(object sender, EventArgs e)
        {
            
            OrderPage uc3 = new OrderPage();
            MainPage.Instance.MainPanel.Controls.Clear();
            MainPage.Instance.MainPanel.Controls.Add(uc3);
            MainPage.Instance.SidePanel.Height = MainPage.Instance.Order.Height;
            MainPage.Instance.SidePanel.Top = MainPage.Instance.Order.Top;             
        }

        private void Manage_Click_1(object sender, EventArgs e)
        {         
            UserControl2 uc2 = new UserControl2();
            MainPage.Instance.MainPanel.Controls.Clear();
            MainPage.Instance.MainPanel.Controls.Add(uc2);
            MainPage.Instance.SidePanel.Height = MainPage.Instance.Account.Height;
            MainPage.Instance.SidePanel.Top = MainPage.Instance.Account.Top;
        }

        private void Item_Click_1(object sender, EventArgs e)
        {
            ItemPage uc4 = new ItemPage();
            MainPage.Instance.MainPanel.Controls.Clear();
            MainPage.Instance.MainPanel.Controls.Add(uc4);
            MainPage.Instance.SidePanel.Height = MainPage.Instance.Item.Height;
            MainPage.Instance.SidePanel.Top = MainPage.Instance.Item.Top;
        }
    }
}

