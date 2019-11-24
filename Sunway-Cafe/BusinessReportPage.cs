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

namespace Sunway_Cafe
{
    public partial class BusinessReportPage : Form
    {
        public BusinessReportPage()
        {
            InitializeComponent();

            using(var db = new SunwayCafeContext())
            {
                var orders = db.OrderedItems.Where(x => x.Order.Status == "Closed")
                    .GroupBy(x => x.ItemId)
                    .Select(x => new BusinessReport()
                    {
                        Name = x.FirstOrDefault().Item.Name,
                        Qty = x.Sum(y => y.Qty),
                        UnitCostPrice = x.FirstOrDefault().Item.CostPrice,
                        UnitSellingPrice = x.FirstOrDefault().Item.SellingPrice,
                    }).ToList();

                var tcp = orders.Sum(x => x.TotalCostPrice);
                var tsp = orders.Sum(x => x.TotalSellingPrice);



                var param = new ReportParameter[]
                {
                    new ReportParameter("Date", Global.ConvToDateTimeString(DateTime.Now)),
                    new ReportParameter("TCP", $"{tcp:0.00}"),
                    new ReportParameter("TSP", $"{tsp:0.00}"),
                    new ReportParameter("TOrder", $"{db.Orders.Where(x => x.Status == "Closed").Count()}"),
                    new ReportParameter("TSST", $"{tsp * 0.06M:0.00}"),
                    new ReportParameter("TSC", $"{tsp * 0.10M:0.00}"),
                    new ReportParameter("TRevenue", $"{tsp - tcp:0.00}"),

                };

                //create a dummy data set
                var ds = new ReportDataSource("BusinessReport", orders.OrderBy(x => x.Name));
                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }

            
        }

        private void BusinessReportPage_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BusinessReportPage_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
