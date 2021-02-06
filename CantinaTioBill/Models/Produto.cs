using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CantinaTioBill.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public decimal Preco { get; set; }
        public virtual List<Ingrediente> Ingredientes { get; set; }
        public virtual List<ProdutoPedido> ProdutoPedidos { get; set; }

    }
}
