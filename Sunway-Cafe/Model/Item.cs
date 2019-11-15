using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe.Model
{
    
    public partial class Item
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SellingPrice { get; set; }

        public byte[] ImageURL { get; set; }

        public virtual ICollection<OrderedItem> OrderedItems { get; set; }

        
    }
}
