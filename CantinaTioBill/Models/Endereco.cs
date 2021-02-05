using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CantinaTioBill.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Rua { get; set; }
        public int Numero { get; set; }
        [StringLength(100)]
        public string Referencia { get; set; }
    }
}
