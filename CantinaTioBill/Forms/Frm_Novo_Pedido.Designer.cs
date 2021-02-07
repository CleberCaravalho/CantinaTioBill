
namespace CantinaTioBill.Forms
{
    partial class Frm_Novo_Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Btn_Procurar = new System.Windows.Forms.Button();
            this.Dgv_Produtos = new System.Windows.Forms.DataGridView();
            this.Btn_Adicionar_Produto = new System.Windows.Forms.Button();
            this.Btn_Excluir_Produto = new System.Windows.Forms.Button();
            this.Btn_Limpar_Produtos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_Produtos_Adicionados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Taxa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Desconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Cmb_Pagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Finalizar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produtos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produtos_Adicionados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente Código";
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(132, 32);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(134, 23);
            this.Txt_Cliente.TabIndex = 1;
            // 
            // Btn_Procurar
            // 
            this.Btn_Procurar.Location = new System.Drawing.Point(398, 31);
            this.Btn_Procurar.Name = "Btn_Procurar";
            this.Btn_Procurar.Size = new System.Drawing.Size(105, 23);
            this.Btn_Procurar.TabIndex = 2;
            this.Btn_Procurar.Text = "Listar Clientes";
            this.Btn_Procurar.UseVisualStyleBackColor = true;
            this.Btn_Procurar.Click += new System.EventHandler(this.Btn_Procurar_Click);
            // 
            // Dgv_Produtos
            // 
            this.Dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Produtos.Location = new System.Drawing.Point(25, 22);
            this.Dgv_Produtos.Name = "Dgv_Produtos";
            this.Dgv_Produtos.RowTemplate.Height = 25;
            this.Dgv_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Produtos.Size = new System.Drawing.Size(251, 150);
            this.Dgv_Produtos.TabIndex = 3;
            // 
            // Btn_Adicionar_Produto
            // 
            this.Btn_Adicionar_Produto.Enabled = false;
            this.Btn_Adicionar_Produto.Location = new System.Drawing.Point(294, 33);
            this.Btn_Adicionar_Produto.Name = "Btn_Adicionar_Produto";
            this.Btn_Adicionar_Produto.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar_Produto.TabIndex = 4;
            this.Btn_Adicionar_Produto.Text = "Adicionar";
            this.Btn_Adicionar_Produto.UseVisualStyleBackColor = true;
            this.Btn_Adicionar_Produto.Click += new System.EventHandler(this.Btn_Adicionar_Produto_Click);
            // 
            // Btn_Excluir_Produto
            // 
            this.Btn_Excluir_Produto.Enabled = false;
            this.Btn_Excluir_Produto.Location = new System.Drawing.Point(294, 77);
            this.Btn_Excluir_Produto.Name = "Btn_Excluir_Produto";
            this.Btn_Excluir_Produto.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir_Produto.TabIndex = 5;
            this.Btn_Excluir_Produto.Text = "Excluir";
            this.Btn_Excluir_Produto.UseVisualStyleBackColor = true;
            // 
            // Btn_Limpar_Produtos
            // 
            this.Btn_Limpar_Produtos.Enabled = false;
            this.Btn_Limpar_Produtos.Location = new System.Drawing.Point(294, 124);
            this.Btn_Limpar_Produtos.Name = "Btn_Limpar_Produtos";
            this.Btn_Limpar_Produtos.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar_Produtos.TabIndex = 6;
            this.Btn_Limpar_Produtos.Text = "Limpar";
            this.Btn_Limpar_Produtos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Dgv_Produtos_Adicionados);
            this.groupBox1.Controls.Add(this.Btn_Limpar_Produtos);
            this.groupBox1.Controls.Add(this.Dgv_Produtos);
            this.groupBox1.Controls.Add(this.Btn_Excluir_Produto);
            this.groupBox1.Controls.Add(this.Btn_Adicionar_Produto);
            this.groupBox1.Location = new System.Drawing.Point(15, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos adicionados";
            // 
            // Dgv_Produtos_Adicionados
            // 
            this.Dgv_Produtos_Adicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Produtos_Adicionados.Location = new System.Drawing.Point(383, 22);
            this.Dgv_Produtos_Adicionados.Name = "Dgv_Produtos_Adicionados";
            this.Dgv_Produtos_Adicionados.RowTemplate.Height = 25;
            this.Dgv_Produtos_Adicionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Produtos_Adicionados.Size = new System.Drawing.Size(269, 150);
            this.Dgv_Produtos_Adicionados.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Endereço de entrega";
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.Enabled = false;
            this.Txt_Endereco.Location = new System.Drawing.Point(133, 122);
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.Size = new System.Drawing.Size(285, 23);
            this.Txt_Endereco.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Taxa de Entrega";
            // 
            // Txt_Taxa
            // 
            this.Txt_Taxa.Enabled = false;
            this.Txt_Taxa.Location = new System.Drawing.Point(133, 165);
            this.Txt_Taxa.Name = "Txt_Taxa";
            this.Txt_Taxa.Size = new System.Drawing.Size(134, 23);
            this.Txt_Taxa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desconto";
            // 
            // Txt_Desconto
            // 
            this.Txt_Desconto.Enabled = false;
            this.Txt_Desconto.Location = new System.Drawing.Point(133, 208);
            this.Txt_Desconto.Name = "Txt_Desconto";
            this.Txt_Desconto.Size = new System.Drawing.Size(134, 23);
            this.Txt_Desconto.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor Total";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Enabled = false;
            this.Txt_Valor.Location = new System.Drawing.Point(133, 248);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(134, 23);
            this.Txt_Valor.TabIndex = 15;
            // 
            // Cmb_Pagamento
            // 
            this.Cmb_Pagamento.FormattingEnabled = true;
            this.Cmb_Pagamento.Items.AddRange(new object[] {
            "Cartão",
            "Dinheiro"});
            this.Cmb_Pagamento.Location = new System.Drawing.Point(427, 245);
            this.Cmb_Pagamento.Name = "Cmb_Pagamento";
            this.Cmb_Pagamento.Size = new System.Drawing.Size(121, 23);
            this.Cmb_Pagamento.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Forma de pagamento";
            // 
            // Btn_Finalizar
            // 
            this.Btn_Finalizar.Location = new System.Drawing.Point(40, 520);
            this.Btn_Finalizar.Name = "Btn_Finalizar";
            this.Btn_Finalizar.Size = new System.Drawing.Size(120, 35);
            this.Btn_Finalizar.TabIndex = 18;
            this.Btn_Finalizar.Text = "Finalizar pedido";
            this.Btn_Finalizar.UseVisualStyleBackColor = true;
            this.Btn_Finalizar.Click += new System.EventHandler(this.Btn_Finalizar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(193, 520);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(120, 35);
            this.Btn_Cancelar.TabIndex = 19;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(299, 31);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 20;
            this.Btn_OK.Text = "Ok";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nome Cliente";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Enabled = false;
            this.Txt_Nome.Location = new System.Drawing.Point(132, 77);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(285, 23);
            this.Txt_Nome.TabIndex = 22;
            // 
            // Frm_Novo_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 567);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Finalizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cmb_Pagamento);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Desconto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Taxa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Procurar);
            this.Controls.Add(this.Txt_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Novo_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo pedido";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produtos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produtos_Adicionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Button Btn_Procurar;
        private System.Windows.Forms.DataGridView Dgv_Produtos;
        private System.Windows.Forms.Button Btn_Adicionar_Produto;
        private System.Windows.Forms.Button Btn_Excluir_Produto;
        private System.Windows.Forms.Button Btn_Limpar_Produtos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Taxa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Desconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.ComboBox Cmb_Pagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Finalizar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.DataGridView Dgv_Produtos_Adicionados;
    }
}