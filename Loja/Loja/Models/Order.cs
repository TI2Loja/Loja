﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        
        [ForeignKey(nameof(Users))]
        public int user_id { get; set; }

        [ForeignKey(nameof(Payment))]
        public int pay_id { get; set; }

        public DateTime ordered { get; set; }

        public DateTime shipped { get; set; }

        public string ship_to { get; set; }

        public string status { get; set; }

        public decimal total { get; set; }


    }
}
