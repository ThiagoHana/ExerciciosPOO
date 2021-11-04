using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._19
{
    enum Resultado { Aprovado, Reprovado }

    class Aluno
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public int qtdFaltas { get; set; }

        public virtual double CalculoMedia()
        {
            return Nota1;
        }

        public int CalculaFrequencia()
        {
            return ((80 - qtdFaltas) * 100) / 80;
        }

        public virtual Resultado Situacao()
        {
            if (CalculaFrequencia() >= 75 && CalculoMedia() >= 7)
                return Resultado.Aprovado;
            else
                return Resultado.Reprovado;
        }

        public override string ToString()
        {
            return $"RA {RA} - Nome: {Nome} - " +
                    $"N1: {Nota1:f1} - Média final: {CalculoMedia():F1} - " +
                    $" Frequencia: { CalculaFrequencia() }% " +
                    $" Situação: { Situacao() }";
        }
    }
}