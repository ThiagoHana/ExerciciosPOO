namespace Ex._16
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbFiltroDificuldade = new System.Windows.Forms.ComboBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonReais = new System.Windows.Forms.Button();
            this.buttonPorcen = new System.Windows.Forms.Button();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.buttonLista = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Dificuldade";
            // 
            // cbFiltroDificuldade
            // 
            this.cbFiltroDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroDificuldade.FormattingEnabled = true;
            this.cbFiltroDificuldade.Items.AddRange(new object[] {
            "easy",
            "normal",
            "hard",
            "TODAS"});
            this.cbFiltroDificuldade.Location = new System.Drawing.Point(9, 197);
            this.cbFiltroDificuldade.Name = "cbFiltroDificuldade";
            this.cbFiltroDificuldade.Size = new System.Drawing.Size(105, 21);
            this.cbFiltroDificuldade.TabIndex = 36;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(124, 197);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(83, 20);
            this.txtAumento.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Valor";
            // 
            // buttonReais
            // 
            this.buttonReais.Location = new System.Drawing.Point(298, 197);
            this.buttonReais.Margin = new System.Windows.Forms.Padding(6);
            this.buttonReais.Name = "buttonReais";
            this.buttonReais.Size = new System.Drawing.Size(70, 37);
            this.buttonReais.TabIndex = 33;
            this.buttonReais.Text = "Aumento por R$";
            this.buttonReais.UseVisualStyleBackColor = true;
            this.buttonReais.Click += new System.EventHandler(this.buttonReais_Click);
            // 
            // buttonPorcen
            // 
            this.buttonPorcen.Location = new System.Drawing.Point(216, 197);
            this.buttonPorcen.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPorcen.Name = "buttonPorcen";
            this.buttonPorcen.Size = new System.Drawing.Size(70, 37);
            this.buttonPorcen.TabIndex = 32;
            this.buttonPorcen.Text = "Aumento por %";
            this.buttonPorcen.UseVisualStyleBackColor = true;
            this.buttonPorcen.Click += new System.EventHandler(this.buttonPorcen_Click);
            // 
            // txtResumo
            // 
            this.txtResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumo.Location = new System.Drawing.Point(9, 280);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResumo.Size = new System.Drawing.Size(379, 110);
            this.txtResumo.TabIndex = 31;
            // 
            // buttonLista
            // 
            this.buttonLista.Location = new System.Drawing.Point(9, 227);
            this.buttonLista.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(54, 44);
            this.buttonLista.TabIndex = 30;
            this.buttonLista.Text = "Listar";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fabricante";
            // 
            // cbFabricante
            // 
            this.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(120, 94);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(136, 21);
            this.cbFabricante.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Dificuldade";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(300, 26);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(88, 20);
            this.txtValor.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Valor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Items.AddRange(new object[] {
            "easy",
            "normal",
            "hard"});
            this.cbDificuldade.Location = new System.Drawing.Point(9, 94);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(105, 21);
            this.cbDificuldade.TabIndex = 22;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código";
            // 
            // buttonSalva
            // 
            this.buttonSalva.Location = new System.Drawing.Point(265, 94);
            this.buttonSalva.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(123, 55);
            this.buttonSalva.TabIndex = 19;
            this.buttonSalva.Text = "Salvar";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(403, 395);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFiltroDificuldade);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReais);
            this.Controls.Add(this.buttonPorcen);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalva);
            this.Name = "Form1";
            this.Text = "Jogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFiltroDificuldade;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonReais;
        private System.Windows.Forms.Button buttonPorcen;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Button buttonLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDificuldade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalva;
    }
}

