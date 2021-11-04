using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7_Sobrecargas
{
    class Program
    {
        static int SomaNumeros(int a, int b)
        {
            return a + b;
        }

        static double SomaNumeros(double a, double b)
        {
            return a + b;
        }

        static double SomaNumeros(string a, string b)
        {
            return Convert.ToDouble(a) + Convert.ToDouble(b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SomaNumeros(9,7));
            Console.WriteLine(SomaNumeros(4.8,7.5));
            Console.WriteLine(SomaNumeros("9.5","4.2"));

            Console.ReadLine();
        }
    }
}
