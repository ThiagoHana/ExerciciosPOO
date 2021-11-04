using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._11_Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ContaCorrente> listaClientes = new List<ContaCorrente>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listaClientes.Add(new ContaCorrente(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text));
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente conta = listaClientes.Find(c => c.Nome == textBox6.Text);
                if (conta == null)
                {
                    textBox7.Text = "Não localizado";
                }
                else
                {
                    conta.Saque(Convert.ToDouble(textBox5.Text));
                    ExibeConta(conta);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente conta = listaClientes.Find(c => c.Nome == textBox6.Text);
                if (conta == null)
                {
                    textBox7.Text = "Não localizado";
                }
                else
                {
                    conta.Deposito(Convert.ToDouble(textBox5.Text));
                    ExibeConta(conta);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void ExibeConta(ContaCorrente conta)
        {
            textBox7.Text += "Conta: " + conta.Conta + "Ag: " + conta.Agencia + "Titular: " + conta.Nome + "Saldo: " + conta.Saldo +
                             Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = listaClientes.Find(c => c.Nome == textBox6.Text);
            if(conta == null)
            {
                textBox7.Text = "Não localizado";
            }
            else
            {
                textBox7.Clear();
                ExibeConta(conta);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = listaClientes.Find(c => c.Nome == textBox6.Text);
            if (conta == null)
            {
                textBox7.Text = "Não localizado";
            }
            else
            {
                listaClientes.Remove(conta);
                MessageBox.Show("Conta Removida!!");
                textBox7.Text = "";
            }
        }
    }
}
