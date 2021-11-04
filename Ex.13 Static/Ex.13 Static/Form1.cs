using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._13_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Funcionario funcionario;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Metodos.ValidaNome(textBox1.Text))
            {
                MessageBox.Show("Insira nome e sobrenome");
                return;
            }

            int idadeFuncionario = 0;

            if (!Metodos.ValidaData(maskedTextBox1.Text.ToString(), out idadeFuncionario))
            {
                MessageBox.Show("Data de nascimento nome invalida");
                return;
            }

            funcionario = new Funcionario(textBox1.Text, Convert.ToDateTime(maskedTextBox1.Text), (Sexo)comboBox2.SelectedIndex, (EstadoCivil)comboBox1.SelectedIndex);

            textBox5.Text = $"Nome - {funcionario.Nome} \r\n" +
                $"Idade - {idadeFuncionario} anos \r\n" +
                $"Sexo - {funcionario.Sexo} \r\n" +
                $"Estado Civil - {funcionario.EstadoCivil}";
        }
    }
}
