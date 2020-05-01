using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja.Models
{
    public class Users
    {
        public int ID { get; set; }
    
        public string role { get; set; }
        
        public string nome { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public DateTime Inc_date { get; set; }
    }
}
