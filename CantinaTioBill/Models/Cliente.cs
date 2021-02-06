using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CantinaTioBill.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        [Required]
        public string Telefone { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
