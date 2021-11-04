using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._12_Alteração_PIlha_Estática
{
    class Pilha
    {
        private readonly int capacidade;
        private string[] dados;
        private int topo = -1;

        public Pilha()
        {
            capacidade = 10;
            dados = new string[capacidade];
        }

        public Pilha(int capacidade)
        {
            this.capacidade = capacidade;
            dados = new string[this.capacidade];
        }

        public int Tamanho()
        {
            return topo + 1;
        }

        public bool Vazia()
        {
            return Tamanho() == 0;
        }

        public void Empilha(string valor)
        {
            if (Tamanho() != capacidade)
            {
                topo++;
                dados[topo] = valor;
            }
            else
                throw new Exception("A pilha está cheia!!!");
        }

        public void Empilha(int posicao, string valor)
        {
            if (Tamanho() == capacidade)
                throw new Exception("A pilha está cheia" + Environment.NewLine);
            else if (posicao > Tamanho())
                throw new Exception("Não pode empilhar nesta posição");
            else
            {
                topo++;
                for (int n = Tamanho() - 1; n > posicao; n--)
                {
                    dados[n] = dados[n - 1];
                }
                dados[posicao] = valor;
            }
        }

        public string Desempilha()
        {
            if (Vazia() == true)
                throw new Exception("A pilha está vazia!!!");
            else
            {
                string retorno = dados[topo];
                dados[topo] = null;
                topo--;
                return retorno;
            }
        }

        public string Desempilha(int posicao)
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha está vazia!!!");
            else if (posicao >= Tamanho())
                throw new Exception("Posição inválida!!!");
            else
            {
                string aux = dados[posicao];
                for (int n = posicao; n < Tamanho() - 1; n++)
                {
                    dados[n] = dados[n + 1];
                }
                topo--;
                return aux;
            }
        }

        public string RetornaTopo()
        {
            if (Vazia() == true)
                throw new Exception("A pilha está vazia!!!");
            else
                return dados[topo];
        }
    }
}
