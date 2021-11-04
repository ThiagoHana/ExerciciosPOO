using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._14_Interface
{
    class Produto : ICadastro
    {
        public int codigo;
        public string nome;
        public double Preco { get; set;}

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome vazio!!");
                else
                    nome = value;
            }
        }

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value == 0)
                    throw new Exception("Codigo maior que zero");
                else
                    codigo = value;
            }
        }

        public void Salvar()
        {
            // produto
            File.AppendAllText("Cadastro.txt", "P|" + Nome + "|" + Codigo + "|" + Preco + Environment.NewLine);
        }

        public bool Pesquisar(string valor)
        {
            if (File.Exists("Cadastro.txt"))
            {
                string[] linhas = File.ReadAllLines("Cadastro.txt");
                foreach (string linha in linhas)
                {
                    string[] dadosLinha = linha.Split('|');

                    if (dadosLinha[0] == "P" || dadosLinha[2] == valor)
                    {
                        Nome = dadosLinha[1];
                        Codigo = Convert.ToInt32(dadosLinha[2]);
                        Preco = Convert.ToDouble(dadosLinha[3]);
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
