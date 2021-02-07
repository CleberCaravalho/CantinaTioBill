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

namespace CantinaTioBill
{
    public partial class Frm_Cliente : UserControl
    {

        int _id = -1;
        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                var cliente = context.Clientes
                    .Include(b => b.Enderecos)
                    .First(c => c.Id == Convert.ToInt32(Txt_Codigo.Text));

                if (!cliente.Equals(null))
                {
                    _id = cliente.Id;
                    CarregarDados(cliente);
                    Txt_Codigo.Text = "";
                    
                }
            }
        }

        private void CarregarDados(Cliente cliente)
        {
            var endereco = cliente.Enderecos.Last();
            Txt_Nome.Text = cliente.Nome;
            Txt_Numero.Text = endereco.Numero.ToString();
            Txt_Rua.Text = endereco.Rua;
            Txt_Bairro.Text = endereco.Bairro;
            Txt_Referencia.Text = endereco.Referencia;

            Msk_Telefone.Text = cliente.Telefone;
        }

        private void EstadoCampos(bool state)
        {
            Txt_Nome.Enabled = state;
            Txt_Numero.Enabled = state;
            Txt_Bairro.Enabled = state;
            Txt_Rua.Enabled = state;
            Txt_Referencia.Enabled = state;
            Msk_Telefone.Enabled = state;
        }

        private void LimparCampos()
        {
            Txt_Nome.Text = "";
            Txt_Numero.Text = "";
            Txt_Bairro.Text = "";
            Txt_Rua.Text = "";
            Txt_Referencia.Text = "";
            Txt_Codigo.Text = "";
            Msk_Telefone.Text = "";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            _id = -1;
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {

            if (CamposValidos())
            {
                using (var context = new ApplicationDBContext())
                {

                    if (_id >= 0)
                    {
                        var cliente = context.Clientes
                        .Include(b => b.Enderecos)
                        .First(c => c.Id == _id);

                        var endereco = new Endereco
                        {
                            Bairro = Txt_Bairro.Text,
                            Numero = Convert.ToInt32(Txt_Numero.Text),
                            Referencia = Txt_Referencia.Text,
                            Rua = Txt_Rua.Text,
                            Cliente = cliente,
                            ClienteId = cliente.Id

                        };

                        cliente.Nome = Txt_Nome.Text;
                        cliente.Telefone = Msk_Telefone.Text;
                        cliente.Enderecos.Add(endereco);

                        context.SaveChanges();
                        _id = -1;
                        LimparCampos();
                    }
                    else
                    {

                        Cliente cliente = new Cliente()
                        {
                            Nome = Txt_Nome.Text,
                            Telefone = Msk_Telefone.Text,
                            Enderecos = new List<Endereco>()
                        };

                        cliente.Enderecos.Add(new Endereco()
                        {
                            Bairro = Txt_Bairro.Text,
                            Numero = Convert.ToInt32(Txt_Numero.Text),
                            Referencia = Txt_Referencia.Text,
                            Rua = Txt_Rua.Text
                        });

                        context.Clientes.Add(cliente);
                        context.SaveChanges();
                        
                    }

                    MessageBox.Show("Cadastro realizado com sucesso", "Salvar");
                    LimparCampos();
                }

            }
            else
            {
                MessageBox.Show("Existem campos vazios", "Atenção");
            }
        }

        private bool CamposValidos()
        {
            if (Txt_Nome.Text != "" &
            Txt_Numero.Text != "" &
            Txt_Bairro.Text != "" &
            Txt_Rua.Text != "" &
            Txt_Referencia.Text != "" &
            Msk_Telefone.Text != "") return true;
            else
                return false;
        }
    }
}
