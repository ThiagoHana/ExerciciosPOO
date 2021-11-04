using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15
{
    class Categoria
    {
        public int codigo { get; set; }
        public string descricao { get; set; }

        public Categoria(int Codigo, string Descricao)
        {
            codigo = Codigo;
            descricao = Descricao;
        }

        public override string ToString()
        {
            return codigo + "-" + descricao;
        }

        public static List<Categoria> ListarCategorias()
        {           
            List<Categoria> minhalista = new List<Categoria>();

            if (File.Exists("categorias.txt"))
            {
                string[] linhas = File.ReadAllLines("categorias.txt", Encoding.Default);
                foreach (string linha in linhas)
                {
                    string[] arquivo = linha.Split(',');
                    minhalista.Add(new Categoria(Convert.ToInt32(arquivo[0]), arquivo[1]));
                }
            }
            return minhalista;
        }

    }
}
