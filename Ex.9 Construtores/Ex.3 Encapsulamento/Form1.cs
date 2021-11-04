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

        Cadastro pessoa;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pessoa = new Cadastro(Convert.ToInt32(PegaCodigo.Text), PegaNome.Text, PegaRG.Text, Convert.ToDouble(PegaSalario.Text));

            ExibeDados.Clear();
            try
            {
                ExibeDados.Text = "Código: " + pessoa.GetPedeCodigo() + Environment.NewLine +
                                 "Nome: " + pessoa.GetPedeNome() + Environment.NewLine +
                                 "RG: " + pessoa.GetPedeRg() + Environment.NewLine +
                                 "Sálario: " + pessoa.GetPedeSalario() + Environment.NewLine +
                                 "Inss: " + pessoa.GetINSS() + Environment.NewLine +
                                 "Salario calculado: " + pessoa.CalculaSalario();
            }
            catch (Exception erro)
            {
                pessoa = null;
                MessageBox.Show(erro.Message);
            }
        }
    }
}
