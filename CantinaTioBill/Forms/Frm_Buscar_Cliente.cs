using CantinaTioBill.Models;
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
    public partial class Frm_Buscar_Cliente : Form
    {
        public Frm_Buscar_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Buscar_Cliente_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            using(var context = new ApplicationDBContext())
            {
                var clientes = context.Clientes.Where(c => c.Nome.Contains(Txt_Nome.Text)).ToList();
                Dgv_Clientes.DataSource = clientes;
            }
        }

        private void CarregarDados()
        {
            using (var context = new ApplicationDBContext())
            {
                var clientes = context.Clientes.ToList();

                Dgv_Clientes.DataSource = clientes;
            }
        }

        private void Txt_Nome_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Nome.Text == "")
            {
                CarregarDados();
            }
        }
    }
}
