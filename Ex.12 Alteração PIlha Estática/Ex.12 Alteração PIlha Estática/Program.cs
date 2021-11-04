using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._12_Alteração_PIlha_Estática
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valor;
            Pilha minhaPilha = new Pilha(10);

            do
            {
                try
                {
                    Console.Write(Environment.NewLine + "Escolha: 1-empilha 2-desempilha " +
                    "3-topo 4-tamanho 5-Empilhar em uma posição " +
                    " 6-Remover de uma posição 9-sair : ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Write("Digite o valor: ");
                        valor = Console.ReadLine();
                        minhaPilha.Empilha(valor);
                    }

                    else if (opcao == 2)
                    {
                        valor = minhaPilha.Desempilha();
                        Console.WriteLine("Desempilhado: {0} \n\n", valor);
                    }

                    else if (opcao == 3)
                    {
                        valor = minhaPilha.RetornaTopo();
                        Console.WriteLine("Topo: {0} \n\n", valor);
                    }

                    else if (opcao == 4)
                    {
                        Console.WriteLine("Tamanho: {0}", minhaPilha.Tamanho());
                    }

                    else if (opcao == 5)
                    {
                        Console.WriteLine("Digite um valor para empilhar:");
                        valor = Console.ReadLine();
                        Console.WriteLine("Digite a posição:");
                        int posicao = Convert.ToInt32(Console.ReadLine());
                        minhaPilha.Empilha(posicao, valor);
                    }

                    else if (opcao == 6)
                    {
                        Console.WriteLine("Digite a posição para desempilhar:");
                        int posicao = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Removido: {0}", minhaPilha.Desempilha(posicao));
                    }

                    else if (opcao == 9)
                    {
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }while (opcao != 9);
        }
    }
}
