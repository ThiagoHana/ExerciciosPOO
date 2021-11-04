using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._17_Herança
{
    class Funcionario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double salario { get; set; }
        
        public virtual double CalculaSalario()
        {
            return salario;
        }

        public override string ToString()
        {
            return $"Codigo: {codigo} - Nome: {nome} - Salário: {salario:F2}";
        }
    }
}
