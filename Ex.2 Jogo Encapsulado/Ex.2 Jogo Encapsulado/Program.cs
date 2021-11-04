using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2_Jogo_Encapsulado
{
    class Program
    {
        static void Main(string[] args)
        {
            jogo[] jogos = new jogo[10];
            int n = 0;

            while (n < 10)
            {
                do
                {
                    jogos[n] = new jogo();
                    try
                    {
                        Console.WriteLine("Digite o Código do Jogo: ");
                        jogos[n].SetPedeCodigo(Convert.ToInt32(Console.ReadLine()));
                        break;
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                } while (true);

                do
                {
                    try
                    {
                        Console.WriteLine("Digite o nome do Jogo: ");
                        jogos[n].SetPedeNome(Console.ReadLine());
                        break;
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                } while (true);

                do
                {
                    try
                    {
                        Console.WriteLine("Digite a Categoria do Jogo (ação, luta, tiro, esportes): ");
                        jogos[n].SetPedeCategoria(Console.ReadLine());
                        break;
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                } while (true);

                do
                {
                    try
                    {
                        Console.WriteLine("Digite a data de lançamento do Jogo: ");
                        jogos[n].SetPedeLancamento(Convert.ToDateTime(Console.ReadLine()));
                        break;
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                } while (true);

                Console.WriteLine("Se deseja cadastrar mais um digite um(1) se nao 2: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                    n +=1;
                else
                    break;
            }

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Dados do Jogo\n\n");
                Console.WriteLine(jogos[i].Atributos());
            }

            Console.ReadLine();
        }
    }
}
