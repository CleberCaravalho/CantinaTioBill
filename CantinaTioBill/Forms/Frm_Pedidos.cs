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
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (var context = new ApplicationDBContext())
            {
                var pedidos = context.Pedidos.ToList();

                Dgv_Pedidos.DataSource = pedidos;
            }
        }

        private void Btn_Novo_Pedido_Click(object sender, EventArgs e)
        {
            Frm_Novo_Pedido FrmNovoPedido = new Frm_Novo_Pedido();
            FrmNovoPedido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text != "")
            {
                using (var context = new ApplicationDBContext())
                {
                    var pedidos = context.Pedidos.Where(p => p.Id == Convert.ToInt32(Txt_Codigo.Text)).ToList();
                    Dgv_Pedidos.DataSource = pedidos;
                }
            }
        }

        private void Btn_Cancelar_Pedido_Click(object sender, EventArgs e)
        {
            if (Dgv_Pedidos.SelectedRows.Count > 0)
            {
                using (var context = new ApplicationDBContext())
                {
                    var pedidoSelecionado = Dgv_Pedidos.SelectedRows[0].DataBoundItem as Pedido;

                    var pedido = context.Pedidos.Where(p => p.Id == pedidoSelecionado.Id).First();

                    if (pedido.Status != Status.Cancelado)
                    {

                        var resposta = MessageBox.Show("Deseja cancelar o pedido?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resposta == DialogResult.Yes)
                        {
                            pedido.Status = Status.Cancelado;

                            context.SaveChanges();

                            CarregarDados();
                        }
                    }
                }
            }
        }
    }
}
