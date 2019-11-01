using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe.Model
{
    public class OrderedItem
    {

        [Key, Column(Order=1)]
        public int OrderId { get; set; }
        [Key, Column(Order=2)]
        public int ItemId { get; set; }
        public int Qty { get; set; }
        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}
