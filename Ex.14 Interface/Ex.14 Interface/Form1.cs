using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._14_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.Codigo = Convert.ToInt32(txtCodigo.Text);
                funcionario.Salvar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSalvaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto.Nome = txtProduto.Text;
                produto.Codigo = Convert.ToInt32(txtCodproduto.Text);
                produto.Preco = Convert.ToDouble(txtPreco.Text);
                produto.Salvar();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            Funcionario funcionario = new Funcionario();
            if (funcionario.Pesquisar(txtPesquisa.Text))
            {
                txtResultado.Text += "Nome: " + funcionario.Nome + " Codigo: " + funcionario.Codigo;
            }
            else
                txtResultado.Clear();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            Produto produto = new Produto();
            if (produto.Pesquisar(txtPesquisaProduto.Text))
            {
                txtResultado.Text += "Nome: " + produto.Nome + " Codigo: " + produto.Codigo + " Preco: " + produto.Preco;
            }
            else
                txtResultado.Clear();
        }
    }
}
