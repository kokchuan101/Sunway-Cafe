
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunway_Cafe.Model
{
    public partial class ReportTest : Form
    {
        public ReportTest()
        {
            InitializeComponent();
            using(var db = new SunwayCafeContext())
            {
                var query = db.Accounts.FirstOrDefault();

                var param = new ReportParameter[]
                {
                    new ReportParameter("username", query.Username),
                    new ReportParameter("role", query.Role)
                };

                //create a dummy data set
                var ds = new ReportDataSource("DataSet1", db.Accounts.ToList());
                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
        }

        private void ReportTest_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.PrintDialog();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
