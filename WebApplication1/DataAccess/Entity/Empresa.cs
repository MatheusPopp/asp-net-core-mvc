using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entity
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }
        [Required]
        public DateTime AnoFundacao { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
        public String Descricao { get; set; }

      
    }
}
