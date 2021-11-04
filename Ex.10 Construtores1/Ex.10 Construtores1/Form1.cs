using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._10_Construtores1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ContaCorrente ContaC;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ContaC = new ContaCorrente(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ContaC.Saque(Convert.ToDouble(textBox5.Text));
                textBox4.Text = ContaC.Saldo.ToString();
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
                ContaC.Deposito(Convert.ToDouble(textBox5.Text));
                textBox4.Text = ContaC.Saldo.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
