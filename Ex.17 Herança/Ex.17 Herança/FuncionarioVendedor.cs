using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._17_Herança
{
    class FuncionarioVendedor : Funcionario
    {
        public double metaDeVendasMesEmReais { get; set; }
        public double vendasDoMesEmReais { get; set; }
        public double porcentagemDeVendas { get; set; }

        public override double CalculaSalario()
        {
            return salario + salario * (porcentagemDeVendas / 100);
        }

        public override string ToString()
        {
            return base.ToString() +
                $" Metas: {metaDeVendasMesEmReais:F2} - Vendas: {vendasDoMesEmReais:F2} -" +
                $" Porcentagem: {porcentagemDeVendas:F2} " + Environment.NewLine;
        }
    }
}
