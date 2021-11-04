using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16
{
    class Jogo
    {
        private int codigo;
        private string nome;
        private double valor;
        public Dificulcade nivel { get; set; }
        public Fabricante Fabri { get; set; }

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("Código inválido");
                else
                    codigo = value;
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Informe o nome");
                else
                    nome = value;
            }
        }

        public double Valor
        {
            get => valor;
            set
            {
                if (value < 1)
                    throw new Exception("Valor incorreto");
                else
                    valor = value;
            }
        }

        public void PrecoAtualizado(int porcento)
        {
            if (porcento <= 0 || porcento > 100)
                throw new Exception("Percentual incorreto.");
            Valor = valor + (porcento / (double)100) * valor;
        }

        public void AtualizaPreco(double valor)
        {
            Valor += valor;
        }

        public override string ToString()
        {
            return $"Código: {Codigo} - Nome: {Nome} - Preço: {Valor:F2} - Dificuldade: {nivel} - Fabricante: {Fabri.nome}";
        }
    }
}
