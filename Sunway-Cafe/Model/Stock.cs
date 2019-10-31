using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe.Model
{
    public class Stock
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public int Qty { get; set; }

        public string Unit { get; set; }

        public int CriticalLevel { get; set; }
    }
}
