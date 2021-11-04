using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._17_Herança
{
    public partial class Form1 : Form
    {
        List<Funcionario> Func = new List<Funcionario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioVendedor f = new FuncionarioVendedor();
                f.codigo = Convert.ToInt32(textBoxCodigo.Text);
                f.nome = textBoxNome.Text;
                f.salario = Convert.ToDouble(textBoxSalario.Text);
                f.metaDeVendasMesEmReais = Convert.ToDouble(textBoxMetas.Text);
                f.vendasDoMesEmReais = Convert.ToDouble(textBoxVendas.Text);
                f.porcentagemDeVendas = Convert.ToInt32(textBoxPorcentagem.Text);

                Func.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioGerente f = new FuncionarioGerente();
                f.codigo = Convert.ToInt32(textBoxCodigo.Text);
                f.nome = textBoxNome.Text;
                f.salario = Convert.ToDouble(textBoxSalario.Text);
                f.qtdFuncionariosSubordinados = Convert.ToInt32(textBoxFunc.Text);
                f.bonusEmReais = Convert.ToDouble(textBoxBonus.Text);

                Func.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioPeao f = new FuncionarioPeao();
                f.codigo = Convert.ToInt32(textBoxCodigo.Text);
                f.nome = textBoxNome.Text;
                f.salario = Convert.ToDouble(textBoxSalario.Text);
                f.horaExtra = Convert.ToInt32(textBoxFunc.Text);

                Func.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
        }

        private void ClearTextBox(Control c)
        {
            if (c is TextBox)
                (c as TextBox).Clear();
            else
            {
                foreach (Control Controle in c.Controls)
                    ClearTextBox(Controle);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
            foreach (Funcionario a in Func)
                textBoxResultado.Text += a.ToString() + Environment.NewLine;
        }
    }
}
