using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class ShoppingCart
    {
        
        [ForeignKey(nameof(Users))]
        public int user_id { get; set; }

        public int quant { get; set; }

        public decimal total { get; set; }
    }
}
