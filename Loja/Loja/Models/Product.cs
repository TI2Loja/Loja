using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string item { get; set; }

        public int stock { get; set; }

        public string description { get; set; }

    }
}
