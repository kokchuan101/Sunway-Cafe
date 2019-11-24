
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        }

        public ReportTest(Receipt rcp)
        {
            InitializeComponent();
            var param = new ReportParameter[]
            {
                    new ReportParameter("Date", rcp.Date),
                    new ReportParameter("Subtotal", $"{rcp.Subtotal}"),
                    new ReportParameter("SST", rcp.CalculateSST()),
                    new ReportParameter("ServCharge", rcp.CalculateServCharge()),
                    new ReportParameter("Total", rcp.CalculateTotal())
            };

            //create a dummy data set
            var ds = new ReportDataSource("Receipt", rcp.ReceiptItems);
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            reportViewer1.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom", 315, 1000);

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
