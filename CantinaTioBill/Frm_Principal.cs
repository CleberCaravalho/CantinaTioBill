using CantinaTioBill.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaTioBill
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Pedido_Click(object sender, EventArgs e)
        {
            Frm_Pedidos FrmPedidos = new Frm_Pedidos();
            Pnl_Formularios.Controls.Clear();
            Pnl_Formularios.Controls.Add(FrmPedidos);
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            Frm_Cliente FrmCliente = new Frm_Cliente();
            Pnl_Formularios.Controls.Clear();
            Pnl_Formularios.Controls.Add(FrmCliente);
        }

        private void Btn_Produtos_Click(object sender, EventArgs e)
        {
            Frm_Produto FrmProduto = new Frm_Produto();
            Pnl_Formularios.Controls.Clear();
            Pnl_Formularios.Controls.Add(FrmProduto);
        }
    }
}
