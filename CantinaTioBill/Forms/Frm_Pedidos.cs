using CantinaTioBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaTioBill.Forms
{
    public partial class Frm_Pedidos : UserControl
    {
        public Frm_Pedidos()
        {
            InitializeComponent();
        }

        private void Frm_Pedidos_Load(object sender, EventArgs e)
        {
            using(var context = new ApplicationDBContext())
            {
                var pedidos =  context.Pedidos.ToList();

                Dgv_Pedidos.DataSource = pedidos;
                //Dgv_Pedidos.Columns["ProdutoPedido"].Visible = false;
                //Dgv_Pedidos.Columns["Cliente"].Visible = false;
            }
        }

        private void Btn_Novo_Pedido_Click(object sender, EventArgs e)
        {
            Frm_Novo_Pedido FrmNovoPedido = new Frm_Novo_Pedido();
            FrmNovoPedido.Show();
        }
    }
}
