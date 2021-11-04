using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16
{
    enum Dificulcade
    {
        easy,
        normal,
        hard
    }

    class Fabricante
    {
        public int codigo { get; set; }
        public string nome { get; set; }


        public Fabricante(int Codigo, string Nome)
        {
            this.codigo = Codigo;
            this.nome = Nome;
        }
    }
}
