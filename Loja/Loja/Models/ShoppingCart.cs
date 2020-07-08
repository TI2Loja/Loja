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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey(nameof(Product))]
        public int prod_id { get; set; }

        [ForeignKey(nameof(Order))]
        public int order_id { get; set; }

        public int quant { get; set; }

        public decimal total { get; set; }
    }
}
