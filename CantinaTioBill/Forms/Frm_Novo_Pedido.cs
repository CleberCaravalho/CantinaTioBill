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
                using (var context = new ApplicationDBContext())
                {
                    _cliente = context.Clientes.Include(c => c.Enderecos)
                        .Where(c => c.Id == Convert.ToInt32(Txt_Cliente.Text)).First();



                    if (!_cliente.Equals(null))
                    {
                        _endereco = _cliente.Enderecos.Last();
                        Txt_Nome.Text = _cliente.Nome;
                        Txt_Endereco.Text = $"{_endereco.Rua}-{_endereco.Numero}-{_endereco.Bairro}";



                        var produtos = context.Produtos.ToList();

                        Dgv_Produtos.DataSource = produtos;
                        CarregarColunas();

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
            DataGridViewRow coluna = new DataGridViewRow();

            for (int i = 0; i < Dgv_Produtos.SelectedRows.Count; i++)
            {
                coluna = (DataGridViewRow)Dgv_Produtos.SelectedRows[i].Clone();
                int intColIndex = 0;
                foreach (DataGridViewCell celula in Dgv_Produtos.SelectedRows[i].Cells)
                {
                    coluna.Cells[intColIndex].Value = celula.Value;
                    intColIndex++;
                }
                Dgv_Produtos_Adicionados.Rows.Add(coluna);
            }
            Dgv_Produtos_Adicionados.AllowUserToAddRows = false;
            Dgv_Produtos_Adicionados.Refresh();

            CalcularValorTotal();


        }

        private void CalcularValorTotal()
        {

             decimal soma = 0;
             for (int i = 0; i < Dgv_Produtos_Adicionados.Rows.Count; ++i)
             {
                soma += (decimal)Dgv_Produtos_Adicionados.Rows[i].Cells[4].Value;
             }

            decimal desconto = Decimal.Parse("0.00");
            if (Dgv_Produtos_Adicionados.Rows.Count >= 5)
            {
                desconto = Decimal.Multiply(soma, (decimal)0.215);
                soma = soma-desconto;
            }
            Txt_Desconto.Text = desconto.ToString();
            Txt_Valor.Text = soma.ToString();
        }

        private void CarregarColunas()
        {
            try
            {
                if (Dgv_Produtos_Adicionados.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in Dgv_Produtos.Columns)
                    {
                        Dgv_Produtos_Adicionados.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produtos selecionados");
            }
        }
    }
}
