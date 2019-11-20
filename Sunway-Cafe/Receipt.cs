using Sunway_Cafe.Model;
using System.Collections.Generic;

namespace Sunway_Cafe
{


    partial class Receipt
    {
        public List<ReceiptItem> ReceiptItems { get; set; }

        public decimal Subtotal { get; set; }

        public string Date { get; set; }

        public string CalculateSST()
        {
            return $"{Subtotal * 0.06M}";
        }

        public string CalculateServCharge()
        {
            return $"{Subtotal * 0.1M}";
        }

        public string CalculateTotal()
        {
            return $"{Subtotal * 1.16M}";
        }


    }
}
