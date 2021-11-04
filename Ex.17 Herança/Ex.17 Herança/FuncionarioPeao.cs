using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._17_Herança
{
    class FuncionarioPeao : Funcionario
    {
        public double horaExtra { get; set; }

        public override double CalculaSalario()
        {
            return salario + horaExtra;
        }

        public override string ToString()
        {
            return base.ToString() + $" Hora Extra: {horaExtra:F2}" + Environment.NewLine;
        }
    }
}
