using System.Linq;

namespace Sunway_Cafe
{


    partial class BusinessReport
    {
        partial class BusinessReportDataTable
        {
        }

        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal UnitCostPrice { get; set; }
        public decimal UnitSellingPrice { get; set; }
        public decimal TotalCostPrice { get => UnitCostPrice * Qty; }
        public decimal TotalSellingPrice { get => UnitSellingPrice * Qty; }


    }
}
