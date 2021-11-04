using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Jogo
{
    class jogo
    {
        public int Codigo;
        public string Nome;
        public string Categoria;
        public DateTime Lancamento;

        public string Atributos()
        {
            return $"-Codigo: {Codigo} \n-Nome: {Nome} \n-Categoria: {Categoria} \n-Data de Lançamento: {Lancamento.ToShortDateString()}";
        }
    }
}
