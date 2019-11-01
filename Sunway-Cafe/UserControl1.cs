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
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _instance;

        
        public static UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UserControl3 uc3 = new UserControl3();
            Form1.Instance.MainPanel.Controls.Clear();
            Form1.Instance.MainPanel.Controls.Add(uc3);
            Form1.Instance.SidePanel.Height = Form1.Instance.Order.Height;
            Form1.Instance.SidePanel.Top = Form1.Instance.Order.Top;
          
            
        }

        private void Manage_Click(object sender, EventArgs e)
        {
          
            UserControl2 uc2 = new UserControl2();
            Form1.Instance.MainPanel.Controls.Clear();
            Form1.Instance.MainPanel.Controls.Add(uc2);
            Form1.Instance.SidePanel.Height = Form1.Instance.Manage.Height;
            Form1.Instance.SidePanel.Top = Form1.Instance.Manage.Top;
        }
    }
}

