using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._3_Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cadastro pessoa = new Cadastro();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pessoa = new Cadastro();

            ExibeDados.Clear();
            try
            {
                pessoa.SetPedeCodigo(Convert.ToInt32(PegaCodigo.Text));
                pessoa.SetPedeNome(Convert.ToString(PegaNome.Text));
                pessoa.SetPedeRG(Convert.ToString(PegaRG.Text));
                pessoa.SetPedeSalario(Convert.ToDouble(PegaSalario.Text));
            }
            catch (Exception erro)
            {
                pessoa = null;
                MessageBox.Show(erro.Message);
            }

            if (pessoa != null)
            {
                ExibeDados.Text = "Código: " + pessoa.GetDevolveCodigo() + Environment.NewLine +
                                  "Nome: " + pessoa.GetDevolveNome() + Environment.NewLine +
                                  "RG: " + pessoa.GetDevolveRG() + Environment.NewLine +
                                  "Sálario: " + pessoa.GetDevolveSalario() + Environment.NewLine +
                                  "Inss: " + pessoa.GetINSS() + Environment.NewLine +
                                  "Salario calculado: " + pessoa.GetCalculaSalario();
            }
            else
                MessageBox.Show("primeiro, crie o funcionário");
        }
    }
}
