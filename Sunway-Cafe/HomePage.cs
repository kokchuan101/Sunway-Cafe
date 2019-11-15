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
        private static HomePage _instance;

        
        public static HomePage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomePage();
                return _instance;
            }
        }
        public HomePage()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OrderPage uc3 = new OrderPage();
            MainPage.Instance.MainPanel.Controls.Clear();
            MainPage.Instance.MainPanel.Controls.Add(uc3);
            MainPage.Instance.SidePanel.Height = MainPage.Instance.Order.Height;
            MainPage.Instance.SidePanel.Top = MainPage.Instance.Order.Top;             
        }

        private void Manage_Click(object sender, EventArgs e)
        {         
            UserControl2 uc2 = new UserControl2();
            MainPage.Instance.MainPanel.Controls.Clear();
            MainPage.Instance.MainPanel.Controls.Add(uc2);
            MainPage.Instance.SidePanel.Height = MainPage.Instance.Manage.Height;
            MainPage.Instance.SidePanel.Top = MainPage.Instance.Manage.Top;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ItemPage uc4 = new ItemPage();
            MainPage.Instance.MainPanel.Controls.Clear();
            MainPage.Instance.MainPanel.Controls.Add(uc4);
            MainPage.Instance.SidePanel.Height = MainPage.Instance.Item.Height;
            MainPage.Instance.SidePanel.Top = MainPage.Instance.Item.Top;
        }
    }
}

