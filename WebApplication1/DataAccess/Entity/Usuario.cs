using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Enum;

namespace WebApplication1.Entity
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public DateTime Data_nasc { get; set; }
        [Required]
        public Genero Genero { get; set; }
        [Required]
        public ICollection<Empresa> Empresas { get; set; }

     
    }
}
