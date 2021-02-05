using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaTioBill.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Preco { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }

    }
}
