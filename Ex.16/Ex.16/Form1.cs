using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            fabricantes.Add(new Fabricante(1, "Konami"));
            fabricantes.Add(new Fabricante(2, "Capcom"));
            fabricantes.Add(new Fabricante(3, "Nintendo"));
            fabricantes.Add(new Fabricante(4, "EA"));
            fabricantes.Add(new Fabricante(5, "Acclaim"));
            fabricantes.Add(new Fabricante(6, "IronHide"));
            fabricantes.Add(new Fabricante(7, "SEGA"));

            InitializeComponent();

            cbFabricante.DataSource = fabricantes;
            cbFabricante.DisplayMember = "Nome";
            cbFiltroDificuldade.SelectedIndex = 3;

            if (File.Exists("jogos.txt"))
            {
                string[] linhas = File.ReadAllLines("jogos.txt");
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split('|');
                    Jogo j = new Jogo()
                    {
                        Codigo = Convert.ToInt32(dados[0]),
                        Nome = dados[1],
                        Valor = Convert.ToDouble(dados[2]),
                        nivel = (Dificulcade)Convert.ToInt32(dados[3]),
                        Fabri = Pesquisa(Convert.ToInt32(dados[4]))
                    };
                    jogos.Add(j);
                }
            }
        }

        List<Fabricante> fabricantes = new List<Fabricante>();
        List<Jogo> jogos = new List<Jogo>();

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            try
            {
                Jogo jogo = new Jogo()
                {
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nome = txtNome.Text,
                    Valor = Convert.ToDouble(txtValor.Text),
                    Fabri = cbFabricante.SelectedItem as Fabricante,
                    nivel = (Dificulcade)cbDificuldade.SelectedIndex
                };

                jogos.Add(jogo);

                string conteudo = "";
                foreach (Jogo j in jogos)
                {
                    conteudo += j.Codigo + "|" +
                        j.Nome + "|" +
                        j.Valor + "|" +
                        (int)j.nivel + "|" +
                        j.Fabri.codigo + Environment.NewLine;
                }
                File.WriteAllText("jogos.txt", conteudo);

                MessageBox.Show("gravado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private Fabricante Pesquisa(int codigo)
        {
            foreach (Fabricante f in fabricantes)
                if (f.codigo == codigo)
                    return f;

            return null;
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            txtResumo.Clear();
            foreach (Jogo j in jogos)
                if (cbFiltroDificuldade.SelectedIndex == 3 ||
                    (int)j.nivel == cbFiltroDificuldade.SelectedIndex)
                    txtResumo.Text += j.ToString() + Environment.NewLine;
        }

        private void buttonPorcen_Click(object sender, EventArgs e)
        {
            try
            {
                int percentual = Convert.ToInt32(txtAumento.Text);
                foreach (Jogo j in jogos)
                    j.AtualizaPreco(percentual);

                string conteudo = "";
                foreach (Jogo j in jogos)
                {
                    conteudo += j.Codigo + "|" +
                        j.Nome + "|" +
                        j.Valor + "|" +
                        (int)j.nivel + "|" +
                        j.Fabri.codigo + Environment.NewLine;
                }
                File.WriteAllText("jogos.txt", conteudo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void buttonReais_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txtAumento.Text);
                foreach (Jogo j in jogos)
                    j.AtualizaPreco(valor);

                string conteudo = "";
                foreach (Jogo j in jogos)
                {
                    conteudo += j.Codigo + "|" +
                        j.Nome + "|" +
                        j.Valor + "|" +
                        (int)j.nivel + "|" +
                        j.Fabri.codigo + Environment.NewLine;
                }
                File.WriteAllText("jogos.txt", conteudo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
