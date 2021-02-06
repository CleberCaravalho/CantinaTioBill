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
        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                var cliente = context.Clientes
                    .Include(b=>b.Enderecos)
                    .Where(c => c.Id == Convert.ToInt32(Txt_Codigo.Text)).FirstOrDefault();
                var endereco = cliente.Enderecos.First();

                if (!cliente.Equals(null))
                {

                    Txt_Nome.Text = cliente.Nome;
                    Txt_Numero.Text = endereco.Numero.ToString();
                    Txt_Rua.Text = endereco.Rua;
                    Txt_Bairro.Text = endereco.Bairro;
                    Txt_Referencia.Text = endereco.Referencia;

                    Msk_Telefone.Text = cliente.Telefone;

                    Txt_Codigo.Text = "";
                    
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
