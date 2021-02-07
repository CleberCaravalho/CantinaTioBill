using CantinaTioBill.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CantinaTioBill.Forms
{
    public partial class Frm_Novo_Pedido : Form
    {

        public Cliente _cliente;

        public Endereco _endereco;
        public Frm_Novo_Pedido()
        {
            InitializeComponent();
            
        }

        private void Btn_Procurar_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Cliente FrmBuscarCliente = new Frm_Buscar_Cliente();
            FrmBuscarCliente.ShowDialog();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Txt_Cliente.Text != "")
            {
                using(var context = new ApplicationDBContext())
                {
                    _cliente = context.Clientes.Include(c=>c.Enderecos)
                        .Where(c => c.Id == Convert.ToInt32(Txt_Cliente.Text)).First();

                   

                    if (!_cliente.Equals(null))
                    {
                        _endereco = _cliente.Enderecos.Last();
                        Txt_Nome.Text = _cliente.Nome;
                        Txt_Endereco.Text = $"{_endereco.Rua}-{_endereco.Numero}-{_endereco.Bairro}";

                        

                        var produtos = context.Produtos.ToList();

                        Dgv_Produtos.DataSource = produtos;
                        Btn_Adicionar_Produto.Enabled = true;
                        Btn_Excluir_Produto.Enabled = true;
                        Btn_Limpar_Produtos.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado", "Error");
                    }
                }
            }
        }

        private void Btn_Adicionar_Produto_Click(object sender, EventArgs e)
        {
            Dgv_Produtos_Adicionados.DataSource = Dgv_Produtos.SelectedRows[0].DataBoundItem;
        }
    }
}
