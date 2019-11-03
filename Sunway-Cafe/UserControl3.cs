using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sunway_Cafe
{
    public partial class UserControl3 : UserControl
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private static UserControl3 _instance;

        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=SunwayCafe.sqlite;Version=3;New=False;Compress=True;");
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from itemTest";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
        }

        public static UserControl3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl3();
                return _instance;
            }
        }
        public UserControl3()
        {
            InitializeComponent();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from itemTest";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DT = new DataTable();
            DB.Fill(DT);

            for (int i=0; i<DT.Rows.Count;i++)
            {
                DataRow dr = DT.Rows[i];

                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["Name_col"].ToString());

                listView1.Items.Add(dr["Name_col"].ToString(), i);
            }

            sql_con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
