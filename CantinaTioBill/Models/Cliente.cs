using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaTioBill.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string Telefone { get; set; }
    }
}
