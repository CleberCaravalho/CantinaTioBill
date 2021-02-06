using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CantinaTioBill.Models
{
    public enum Status
    {
        Entregue, Confirmado, Cancelado
    }

    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public ICollection<ProdutoPedido> ProdutoPedidos { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public Status Status { get; set; }
        public decimal Desconto { get; set; }
        public decimal TaxaEntrega { get; set; }
        public decimal Valor { get; set; }
        public int FormaPagamento { get; set; }
        public decimal Troco { get; set; }
        public DateTime Data { get; set; }
    }
}
