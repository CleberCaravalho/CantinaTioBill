using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CantinaTioBill.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Rua { get; set; }
        [Required]
        public int Numero { get; set; }
        public string Bairro { get; set; }
        [StringLength(100)]
        public string Referencia { get; set; }

        public Cliente Cliente { get; set; }

        public int ClienteId { get; set; }

    }
}
