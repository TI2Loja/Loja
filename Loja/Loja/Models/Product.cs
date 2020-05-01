using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        public string item { get; set; }

        public int stock { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

    }
}
