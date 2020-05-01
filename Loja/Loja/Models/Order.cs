using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Order
    {
        [ForeignKey(nameof(Users))]
        public int user_id { get; set; }

        public DateTime ordered { get; set; }

        public DateTime shipped { get; set; }

        public string ship_to { get; set; }

        public string status { get; set; }

        public decimal total { get; set; }


    }
}
