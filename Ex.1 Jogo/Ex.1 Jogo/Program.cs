using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            jogo jogos = new jogo();

            do
            {
                try
                {
                    Console.WriteLine("Digite o Código do Jogo: ");
                    jogos.Codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite inteiros maiores que 0!!");
                }
            } while (jogos.Codigo <= 0);

            do
            {
                Console.WriteLine("Digite o nome do Jogo: ");
                jogos.Nome = Console.ReadLine();
            }while(jogos.Nome.Trim() == "");

            do
            {
                Console.WriteLine("Digite a Categoria do Jogo: ");
                jogos.Categoria = Console.ReadLine();
            } while(jogos.Categoria.Trim() == "");

            do
            {
                try
                {
                    Console.WriteLine("Digite a data de lançamento do Jogo: ");
                    jogos.Lancamento = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Digite no formato correto!!");
                }
            } while (true);

            Console.WriteLine("Dados do Jogo\n\n");
            Console.WriteLine(jogos.Atributos());

            Console.ReadLine();
        }
    }
}
