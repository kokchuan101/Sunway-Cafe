using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe.Model
{
    public class ReceiptItem
    {
        public int Qty { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Price { get => Qty * UnitPrice;  }

    }
}
