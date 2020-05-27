using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Payment
    {
        [Key]
        public int _id { get; set; }

        public decimal total { get; set; }

        public string details { get; set; }

        [Required(ErrorMessage = "O Tipo de pagamento é de preenchimento obrigatório")]
        [StringLength(20, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")]
        public string type { get; set; }
    }
}
