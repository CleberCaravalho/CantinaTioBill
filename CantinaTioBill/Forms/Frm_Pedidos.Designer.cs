
namespace CantinaTioBill.Forms
{
    partial class Frm_Pedidos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv_Pedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Btn_Novo_Pedido = new System.Windows.Forms.Button();
            this.Btn_Cancelar_Pedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Pedidos
            // 
            this.Dgv_Pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Dgv_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pedidos.Location = new System.Drawing.Point(14, 98);
            this.Dgv_Pedidos.Name = "Dgv_Pedidos";
            this.Dgv_Pedidos.RowTemplate.Height = 25;
            this.Dgv_Pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Pedidos.Size = new System.Drawing.Size(677, 334);
            this.Dgv_Pedidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.Txt_Codigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(230, 16);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Ir";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(67, 17);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(157, 23);
            this.Txt_Codigo.TabIndex = 2;
            // 
            // Btn_Novo_Pedido
            // 
            this.Btn_Novo_Pedido.Location = new System.Drawing.Point(396, 28);
            this.Btn_Novo_Pedido.Name = "Btn_Novo_Pedido";
            this.Btn_Novo_Pedido.Size = new System.Drawing.Size(105, 32);
            this.Btn_Novo_Pedido.TabIndex = 3;
            this.Btn_Novo_Pedido.Text = "Novo Pedido";
            this.Btn_Novo_Pedido.UseVisualStyleBackColor = true;
            this.Btn_Novo_Pedido.Click += new System.EventHandler(this.Btn_Novo_Pedido_Click);
            // 
            // Btn_Cancelar_Pedido
            // 
            this.Btn_Cancelar_Pedido.Location = new System.Drawing.Point(533, 28);
            this.Btn_Cancelar_Pedido.Name = "Btn_Cancelar_Pedido";
            this.Btn_Cancelar_Pedido.Size = new System.Drawing.Size(105, 32);
            this.Btn_Cancelar_Pedido.TabIndex = 4;
            this.Btn_Cancelar_Pedido.Text = "Cancelar Pedido";
            this.Btn_Cancelar_Pedido.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_Pedido.Click += new System.EventHandler(this.Btn_Cancelar_Pedido_Click);
            // 
            // Frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Cancelar_Pedido);
            this.Controls.Add(this.Btn_Novo_Pedido);
            this.Controls.Add(this.Dgv_Pedidos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Pedidos";
            this.Size = new System.Drawing.Size(705, 451);
            this.Load += new System.EventHandler(this.Frm_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Pedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Button Btn_Novo_Pedido;
        private System.Windows.Forms.Button Btn_Cancelar_Pedido;
    }
}
