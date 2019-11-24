using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe.Model
{
    public class Stock
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Positive integer only.")]
        public string Qty { get; set; }

        public string Unit { get; set; }

        [Required]
        public string CriticalLevel { get; set; }
    }
}
