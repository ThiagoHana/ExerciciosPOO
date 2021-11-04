namespace Ex._14_Interface
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtCodproduto = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSalvaFunc = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvaProduto = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesquisa Funcionario";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(324, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(38, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(38, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(327, 44);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 8;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(38, 246);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(140, 20);
            this.txtPesquisa.TabIndex = 9;
            // 
            // txtCodproduto
            // 
            this.txtCodproduto.Location = new System.Drawing.Point(327, 88);
            this.txtCodproduto.Name = "txtCodproduto";
            this.txtCodproduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodproduto.TabIndex = 10;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(327, 211);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(187, 138);
            this.txtResultado.TabIndex = 12;
            // 
            // btnSalvaFunc
            // 
            this.btnSalvaFunc.Location = new System.Drawing.Point(38, 142);
            this.btnSalvaFunc.Name = "btnSalvaFunc";
            this.btnSalvaFunc.Size = new System.Drawing.Size(78, 47);
            this.btnSalvaFunc.TabIndex = 13;
            this.btnSalvaFunc.Text = "Salvar";
            this.btnSalvaFunc.UseVisualStyleBackColor = true;
            this.btnSalvaFunc.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(201, 219);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(78, 47);
            this.btnPesquisa.TabIndex = 14;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Resultado";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(327, 138);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Preço";
            // 
            // btnSalvaProduto
            // 
            this.btnSalvaProduto.Location = new System.Drawing.Point(439, 138);
            this.btnSalvaProduto.Name = "btnSalvaProduto";
            this.btnSalvaProduto.Size = new System.Drawing.Size(78, 47);
            this.btnSalvaProduto.TabIndex = 18;
            this.btnSalvaProduto.Text = "Salvar";
            this.btnSalvaProduto.UseVisualStyleBackColor = true;
            this.btnSalvaProduto.Click += new System.EventHandler(this.btnSalvaProduto_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(201, 286);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(78, 47);
            this.btnProduto.TabIndex = 21;
            this.btnProduto.Text = "Pesquisar";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(38, 313);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(140, 20);
            this.txtPesquisaProduto.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pesquisa Produto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 365);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.txtPesquisaProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalvaProduto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnSalvaFunc);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCodproduto);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtCodproduto;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSalvaFunc;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvaProduto;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Label label7;
    }
}

