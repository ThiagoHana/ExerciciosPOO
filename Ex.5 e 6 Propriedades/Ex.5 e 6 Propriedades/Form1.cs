using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._5_e_6_Propriedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Aluno[] alunos = new Aluno[10];
        int conta = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (conta < 10)
            {
                alunos[conta] = new Aluno();
                try
                {
                    alunos[conta].PegaNome = Convert.ToString(txtNome.Text);
                    alunos[conta].PegaNota1 = Convert.ToDouble(txtNota1.Text);
                    alunos[conta].PegaNota2 = Convert.ToDouble(txtNota2.Text);
                    conta++;

                    txtNome.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                }
                catch (Exception erro)
                {
                    alunos[conta] = null;
                    MessageBox.Show(erro.Message);
                }
            }
            else
                MessageBox.Show("Máximo 10 alunos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conta > 0)
            {
                txtExibe.Clear();
                for ( int qtd = 0; qtd < conta; qtd++)
                {
                    if (alunos != null)
                        txtExibe.Text += "Nome: " + alunos[qtd].PegaNome + Environment.NewLine +
                                         "Nota1: " + alunos[qtd].PegaNota1 + Environment.NewLine +
                                         "nota2: " + alunos[qtd].PegaNota2 + Environment.NewLine +
                                         "Media: " + alunos[qtd].RetornaMedia + Environment.NewLine + Environment.NewLine;
                }
            }
            else
                MessageBox.Show("Adicione um aluno antes!!");
        }
    }
}
