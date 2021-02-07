
namespace CantinaTioBill.Forms
{
    partial class Frm_Produto
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Preco = new System.Windows.Forms.TextBox();
            this.Ckl_Ingredientes = new System.Windows.Forms.CheckedListBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Txt_Novo_Ingrediente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(141, 37);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(274, 23);
            this.Txt_Nome.TabIndex = 1;
            // 
            // Cmb_Categoria
            // 
            this.Cmb_Categoria.FormattingEnabled = true;
            this.Cmb_Categoria.Location = new System.Drawing.Point(141, 85);
            this.Cmb_Categoria.Name = "Cmb_Categoria";
            this.Cmb_Categoria.Size = new System.Drawing.Size(182, 23);
            this.Cmb_Categoria.TabIndex = 2;
            this.Cmb_Categoria.Click += new System.EventHandler(this.Cmb_Categoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.Location = new System.Drawing.Point(141, 133);
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(182, 23);
            this.Txt_Preco.TabIndex = 5;
            // 
            // Ckl_Ingredientes
            // 
            this.Ckl_Ingredientes.FormattingEnabled = true;
            this.Ckl_Ingredientes.Items.AddRange(new object[] {
            "Carne de Sol",
            "Arroz",
            "Feijão",
            "Macarrão",
            "Linguiça",
            "Frango",
            "Churrasco",
            "Feijoada",
            "Baião"});
            this.Ckl_Ingredientes.Location = new System.Drawing.Point(42, 54);
            this.Ckl_Ingredientes.Name = "Ckl_Ingredientes";
            this.Ckl_Ingredientes.Size = new System.Drawing.Size(301, 130);
            this.Ckl_Ingredientes.TabIndex = 7;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(22, 409);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(116, 33);
            this.Btn_Salvar.TabIndex = 8;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(207, 409);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(116, 33);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 379);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ckl_Ingredientes);
            this.groupBox2.Controls.Add(this.Btn_Adicionar);
            this.groupBox2.Controls.Add(this.Txt_Novo_Ingrediente);
            this.groupBox2.Location = new System.Drawing.Point(21, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 203);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(249, 25);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(99, 23);
            this.Btn_Adicionar.TabIndex = 11;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Txt_Novo_Ingrediente
            // 
            this.Txt_Novo_Ingrediente.Location = new System.Drawing.Point(42, 25);
            this.Txt_Novo_Ingrediente.Name = "Txt_Novo_Ingrediente";
            this.Txt_Novo_Ingrediente.PlaceholderText = "Novo Ingrediente";
            this.Txt_Novo_Ingrediente.Size = new System.Drawing.Size(182, 23);
            this.Txt_Novo_Ingrediente.TabIndex = 8;
            // 
            // Frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_Categoria);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Produto";
            this.Size = new System.Drawing.Size(723, 463);
            this.Load += new System.EventHandler(this.Frm_Produto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.ComboBox Cmb_Categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Preco;
        private System.Windows.Forms.CheckedListBox Ckl_Ingredientes;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.TextBox Txt_Novo_Ingrediente;
    }
}
