using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._19
{
    class AlunoEM : Aluno
    {
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public string Responsavel { get; set; }

        public override double CalculoMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public override Resultado Situacao()
        {
            if (CalculaFrequencia() >= 75 && CalculoMedia() >= 6)
                return Resultado.Aprovado;
            else
                return Resultado.Reprovado;
        }

        public override string ToString()
        {
            return base.ToString() +
                $" Nota 2: {Nota2:F1}  Nota 3: {Nota3:F1}  " +
                $" Responsável: { Responsavel } ";
        }
    }
}