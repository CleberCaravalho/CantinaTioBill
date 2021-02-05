namespace CantinaTioBill.Models
{
    public class ProdutoPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    }
}