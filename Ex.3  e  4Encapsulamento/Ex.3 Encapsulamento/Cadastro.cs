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

        public int PedeCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Código tem que ser mair que zero!!");
                else
                    codigo = value;
            }
        }

        /*public void SetPedeCodigo(int codigo)
        {
            if (codigo <= 0)
                throw new Exception("Código tem que ser mair que zero!!");
            else
                this.codigo = codigo;
        }

        public int GetDevolveCodigo() => codigo;*/

        public string PedeNome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value == "")
                    throw new Exception("Preencha o nome!!");
                else
                    nome = value;
            }
        }

        /*public void SetPedeNome(string nome)
        {
            if (nome == "")
                throw new Exception("Preencha o nome!!");
            else
                this.nome = nome;
        }

        public string GetDevolveNome() => nome;*/

        public string PedeRg
        {
            get
            {
                return rg;
            }
            set
            {
                if (value == "")
                    throw new Exception("Preencha o RG!!");
                else
                    rg = value;
            }
        }

        /*public void SetPedeRG(string rg)
        {
            if (rg == "")
                throw new Exception("Preencha o RG!!");
            else
                this.rg = rg;
        }

        public string GetDevolveRG() => rg;*/

        public double PedeSalario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Salário Invalido!!");
                else
                    salario = value;
            }
        }

        /*public void SetPedeSalario(double salario)
        {
            if (salario <= 0)
                throw new Exception("Salário Invalido!!");
            else
                this.salario = salario;
        }

        public double GetDevolveSalario() => salario;*/

        public double INSS
        {
            get
            {
                return salario * 0.11;
            }
        }

        /*public double GetINSS()
        {
            return salario * 0.11;
        }*/

        public double CalculaSalario
        {
            get
            {
                return salario - INSS;
            }
        }

        /*public double GetCalculaSalario()
        {
            double totalsalario;
            return totalsalario = salario - salariocalculado;
        }*/
    }
}
