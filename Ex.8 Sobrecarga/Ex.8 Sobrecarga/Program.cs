using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8_Sobrecarga
{
    class Program
    {
        // As dimensões está de acordo com o meu computador com a tela maximizada
        static void Texto(string frase)
        {
            int posicao = (Console.WindowWidth - frase.Length) / 2;
            Console.CursorLeft = posicao;
        }

        static void Texto()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        static void Main(string[] args)
        {
            string frase;

            do
            {
                Console.WriteLine("Digite uma frase: ");
                frase = Console.ReadLine();
            } while (frase.Trim() == "");

            Console.Clear();
            Texto();
            Texto(frase);
            Console.Write(frase);

            Console.ReadLine();
        }
    }
}
