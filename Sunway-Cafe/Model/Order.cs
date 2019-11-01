using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunway_Cafe.Model
{
    
    public class Order
    {
    
        public int Id { get; set; }

        public string Items { get; set; }

        public decimal NetPrice { get; set; }

        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public string DateTime { get; set; }
    }
}
