using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._19
{
    public partial class Form1 : Form
    {
        List<Aluno> alunos = new List<Aluno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoEM a = new AlunoEM();
                PreenchePropriedadesAluno(a);
                a.Nota2 = Convert.ToDouble(txtN2_EM.Text);
                a.Nota3 = Convert.ToDouble(txtN3_EM.Text);
                a.Responsavel = txtResponsavel.Text;
                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoFTT a = new AlunoFTT();
                PreenchePropriedadesAluno(a);
                a.Nota2 = Convert.ToDouble(txtN2_FTT.Text);
                a.HorasEstagio = Convert.ToInt32(txtHorasEstagio.Text);
                alunos.Add(a);
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
                AlunoPOS a = new AlunoPOS();
                PreenchePropriedadesAluno(a);
                a.FaculdadeFormacao = txtGraduacao.Text;

                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void PreenchePropriedadesAluno(Aluno a) 
        {
            a.RA = Convert.ToInt32(txtRA.Text);
            a.Nome = txtNomeAluno.Text;
            a.Nota1 = Convert.ToDouble(txtN1.Text);
            a.qtdFaltas = Convert.ToInt32(txtNumFaltas.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Aluno a in alunos)
            {
                txtListagem.Text += $"RA {a.RA} - Nome: {a.Nome} - " +
                    $"N1: {a.Nota1:f1} - Média final: {a.CalculoMedia():F1} - ";

                if (a is AlunoEM)
                    txtListagem.Text += $" Nota 2: { (a as AlunoEM).Nota2 }  " +
                                        $" Nota 3: { (a as AlunoEM).Nota3 }  " +
                                        $" Responsável: { (a as AlunoEM).Responsavel } " + Environment.NewLine;
                else if (a is AlunoFTT)
                    txtListagem.Text += $" Nota 2: { (a as AlunoFTT).Nota2 }  " +
                                        $" Horas de estágio: { (a as AlunoFTT).HorasEstagio}" + Environment.NewLine;
                else
                    txtListagem.Text += $" Falculdade: { (a as AlunoPOS).FaculdadeFormacao }  " + Environment.NewLine;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Aluno a in alunos)
                txtListagem.Text += a.ToString() + Environment.NewLine;
        }

        private void listarEM_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            alunos.FindAll(aluno => aluno is AlunoEM).ForEach(alunoEM => txtListagem.Text += alunoEM.ToString() + Environment.NewLine);
        }

        private void listarFtt_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            alunos.FindAll(aluno => aluno is AlunoFTT).ForEach(alunoEM => txtListagem.Text += alunoEM.ToString() + Environment.NewLine);
        }

        private void listarPos_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            alunos.FindAll(aluno => aluno is AlunoPOS).ForEach(alunoEM => txtListagem.Text += alunoEM.ToString() + Environment.NewLine);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtN2_FTT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}