using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Categoria> lista = Categoria.ListarCategorias();
            cbCategoria.DataSource = lista;
            cbCategoria.DisplayMember = "Descricao";
        }

        List<Produto> produtos = new List<Produto>();

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                Produto prod = new Produto();
                prod.codigo = Convert.ToInt32(txtCodigo.Text);
                prod.descricao = txtDescricao.Text;
                prod.Categoria = cbCategoria.SelectedItem as Categoria;
                produtos.Add(prod);

                txtCodigo.Clear();
                txtDescricao.Clear();
                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void buttonlist_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            foreach (Produto prod in produtos)
            {
                txtResultado.Text += prod.codigo + " - " +
                    prod.descricao + " - " + prod.Categoria.descricao +
                    Environment.NewLine;
            }
        }
    }
}
