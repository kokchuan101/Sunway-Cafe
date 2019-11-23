using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe.Model
{
    
    public partial class Item
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Negative number is not allowed.")]
        public decimal CostPrice { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Negative number is not allowed.")]
        public decimal SellingPrice { get; set; }

        [Required]
        public byte[] ImageURL { get; set; }

        public virtual ICollection<OrderedItem> OrderedItems { get; set; }

        
    }
}
