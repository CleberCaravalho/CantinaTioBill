using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CantinaTioBill.Models
{
    public class ProdutoPedido
    {
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    }
}