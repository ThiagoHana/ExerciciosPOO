namespace Ex._3_Encapsulamento
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
            this.label4 = new System.Windows.Forms.Label();
            this.PegaCodigo = new System.Windows.Forms.TextBox();
            this.PegaNome = new System.Windows.Forms.TextBox();
            this.PegaSalario = new System.Windows.Forms.TextBox();
            this.PegaRG = new System.Windows.Forms.MaskedTextBox();
            this.ExibeDados = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salário";
            // 
            // PegaCodigo
            // 
            this.PegaCodigo.Location = new System.Drawing.Point(148, 59);
            this.PegaCodigo.Name = "PegaCodigo";
            this.PegaCodigo.Size = new System.Drawing.Size(100, 20);
            this.PegaCodigo.TabIndex = 4;
            // 
            // PegaNome
            // 
            this.PegaNome.Location = new System.Drawing.Point(148, 102);
            this.PegaNome.Name = "PegaNome";
            this.PegaNome.Size = new System.Drawing.Size(100, 20);
            this.PegaNome.TabIndex = 5;
            // 
            // PegaSalario
            // 
            this.PegaSalario.Location = new System.Drawing.Point(148, 197);
            this.PegaSalario.Name = "PegaSalario";
            this.PegaSalario.Size = new System.Drawing.Size(100, 20);
            this.PegaSalario.TabIndex = 6;
            // 
            // PegaRG
            // 
            this.PegaRG.Location = new System.Drawing.Point(148, 150);
            this.PegaRG.Mask = "00.000.000-00";
            this.PegaRG.Name = "PegaRG";
            this.PegaRG.Size = new System.Drawing.Size(100, 20);
            this.PegaRG.TabIndex = 7;
            // 
            // ExibeDados
            // 
            this.ExibeDados.Location = new System.Drawing.Point(268, 59);
            this.ExibeDados.Multiline = true;
            this.ExibeDados.Name = "ExibeDados";
            this.ExibeDados.Size = new System.Drawing.Size(274, 158);
            this.ExibeDados.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(158, 237);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 42);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar e exibir";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ExibeDados);
            this.Controls.Add(this.PegaRG);
            this.Controls.Add(this.PegaSalario);
            this.Controls.Add(this.PegaNome);
            this.Controls.Add(this.PegaCodigo);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PegaCodigo;
        private System.Windows.Forms.TextBox PegaNome;
        private System.Windows.Forms.TextBox PegaSalario;
        private System.Windows.Forms.MaskedTextBox PegaRG;
        private System.Windows.Forms.TextBox ExibeDados;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

