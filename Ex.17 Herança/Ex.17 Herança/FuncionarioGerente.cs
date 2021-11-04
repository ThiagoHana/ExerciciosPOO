using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._17_Herança
{
    class FuncionarioGerente : Funcionario
    {
        public int qtdFuncionariosSubordinados { get; set; }
        public double bonusEmReais { get; set; }

        public override double CalculaSalario()
        {
            return salario + bonusEmReais;
        }

        public override string ToString()
        {
            return base.ToString() + $" Funcionários: {qtdFuncionariosSubordinados} - Bonus: {bonusEmReais:F2} " + Environment.NewLine;                
        }
    }
}
