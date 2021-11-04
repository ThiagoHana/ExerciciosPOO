using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3_Encapsulamento
{
    public class Cadastro
    {
        private int codigo = 0;
        private string nome;
        private string rg;
        private double salario;
        private double salariocalculado;

        public void SetPedeCodigo(int codigo)
        {
            if (codigo <= 0)
                throw new Exception("Código tem que ser mair que zero!!");
            else
                this.codigo = codigo;
        }

        public int GetDevolveCodigo() => codigo;

        public void SetPedeNome(string nome)
        {
            if (nome == "")
                throw new Exception("Preencha o nome!!");
            else
                this.nome = nome;
        }

        public string GetDevolveNome() => nome;

        public void SetPedeRG(string rg)
        {
            if (rg == "")
                throw new Exception("Preencha o RG!!");
            else
                this.rg = rg;
        }

        public string GetDevolveRG() => rg;

        public void SetPedeSalario(double salario)
        {
            if (salario <= 0)
                throw new Exception("Salário Invalido!!");
            else
                this.salario = salario;
        }

        public double GetDevolveSalario() => salario;

        public double GetINSS()
        {
            salariocalculado = salario * 0.11;
            return salariocalculado;
        }

        public double GetCalculaSalario()
        {
            double totalsalario;
            return totalsalario = salario - salariocalculado;
        }
    }
}
