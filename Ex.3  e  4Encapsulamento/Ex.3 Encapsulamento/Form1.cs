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
               pessoa.PedeCodigo = Convert.ToInt32(PegaCodigo.Text);
                pessoa.PedeNome = Convert.ToString(PegaNome.Text);
                pessoa.PedeRg = Convert.ToString(PegaRG.Text);
                pessoa.PedeSalario = Convert.ToDouble(PegaSalario.Text);
            }
            catch (Exception erro)
            {
                pessoa = null;
                MessageBox.Show(erro.Message);
            }

            if (pessoa != null)
            {
                ExibeDados.Text = "Código: " + pessoa.PedeCodigo + Environment.NewLine +
                                  "Nome: " + pessoa.PedeNome + Environment.NewLine +
                                  "RG: " + pessoa.PedeRg + Environment.NewLine +
                                  "Sálario: " + pessoa.PedeSalario + Environment.NewLine +
                                  "Inss: " + pessoa.INSS + Environment.NewLine +
                                  "Salario calculado: " + pessoa.CalculaSalario;
            }
            else
                MessageBox.Show("primeiro, crie o funcionário");
        }
    }
}
