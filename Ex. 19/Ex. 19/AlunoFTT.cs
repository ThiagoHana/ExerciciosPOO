using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._19
{
    class AlunoFTT :Aluno
    {
        public double Nota2 { get; set; }
        public int HorasEstagio { get; set; }

        public override double CalculoMedia()
        {
            return Nota1 * 0.4 + Nota2 * 0.6;
        }
        public override Resultado Situacao()
        {
            if (CalculaFrequencia() >= 75 && CalculoMedia() >= 6)
                return Resultado.Aprovado;
            else
                return Resultado.Reprovado;
        }
    }
}