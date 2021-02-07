using CantinaTioBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace CantinaTioBill.Forms
{
    public partial class Frm_Produto : UserControl
    {
        public Frm_Produto()
        {
            InitializeComponent();
        }

        private void Frm_Produto_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_Categoria_Click(object sender, EventArgs e)
        {
            if (Cmb_Categoria.Items.Count == 0)
            {
                using (var context = new ApplicationDBContext())
                {
                    var categorias = context.Categorias.ToList();

                    if (categorias.Count() == 0)
                    {
                        Cmb_Categoria.Items.Add("Quentinha");
                        Cmb_Categoria.Items.Add("Bebida");
                    }
                    else
                    {
                        foreach (var categoria in categorias)
                        {
                            Cmb_Categoria.Items.Add(categoria.Nome);
                        }
                    }
                }
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            using(var context = new ApplicationDBContext())
            {
                var categoria = context.Categorias.Where(c => c.Id == Cmb_Categoria.SelectedIndex+1).FirstOrDefault();
                var produto = new Produto()
                {
                    Nome = Txt_Nome.Text,
                    Preco = Convert.ToDecimal(Txt_Preco.Text),
                    Ingredientes = new List<Ingrediente>(),
                    Categoria = categoria
                };

                foreach(var ingrediente in Ckl_Ingredientes.CheckedItems)
                {
                    produto.Ingredientes.Add(new Ingrediente() { Nome = ingrediente.ToString() });
                }

                context.Produtos.Add(produto);
                context.SaveChanges();

                MessageBox.Show("Produto cadastrado com sucesso", "Produto");
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            Txt_Nome.Text = "";
            Txt_Novo_Ingrediente.Text = "";
            Txt_Preco.Text = "";
            Cmb_Categoria.ResetText();
            Ckl_Ingredientes.ClearSelected();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (Txt_Novo_Ingrediente.Text != "")
            {
                var novo = Txt_Novo_Ingrediente.Text;

                Ckl_Ingredientes.Items.Add(novo, true);
            }
        }
    }
}
