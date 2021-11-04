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

        public Cadastro(int codigo, string nome, string rg, double salario)
        {
            SetPedeCodigo(codigo);
            SetPedeNome(nome);
            SetPedeRg(rg);
            SetPedeSalario(salario);
        }

        public int GetPedeCodigo() => codigo;
        public void SetPedeCodigo(int codigo)
        {
                if (codigo <= 0)
                    throw new Exception("Código tem que ser mair que zero!!");
                else
                    this.codigo = codigo;
            
        }

        /*public void SetPedeCodigo(int codigo)
        {
            if (codigo <= 0)
                throw new Exception("Código tem que ser mair que zero!!");
            else
                this.codigo = codigo;
        }

        public int GetDevolveCodigo() => codigo;*/

        public string GetPedeNome() => nome;
        public void SetPedeNome(string nome)
        {
                if (nome == "")
                    throw new Exception("Preencha o nome!!");
                else
                    this.nome = nome;
        }

        /*public void SetPedeNome(string nome)
        {
            if (nome == "")
                throw new Exception("Preencha o nome!!");
            else
                this.nome = nome;
        }

        public string GetDevolveNome() => nome;*/

        public string GetPedeRg() => rg;
        public void SetPedeRg(string rg)
        {  
                if (rg == "")
                    throw new Exception("Preencha o RG!!");
                else
                    this.rg = rg;
        }

        /*public void SetPedeRG(string rg)
        {
            if (rg == "")
                throw new Exception("Preencha o RG!!");
            else
                this.rg = rg;
        }

        public string GetDevolveRG() => rg;*/

        public double GetPedeSalario() => salario;
        public void SetPedeSalario(double salario)
        {                    
                if (salario <= 0)
                    throw new Exception("Salário Invalido!!");
                else
                    this.salario = salario;
        }

        /*public void SetPedeSalario(double salario)
        {
            if (salario <= 0)
                throw new Exception("Salário Invalido!!");
            else
                this.salario = salario;
        }

        public double GetDevolveSalario() => salario;*/

        public double GetINSS()
        {   
                return salario * 0.11;
        }

        /*public double GetINSS()
        {
            return salario * 0.11;
        }*/

        public double CalculaSalario()
        {
            return salario - GetINSS();
        }

        /*public double GetCalculaSalario()
        {
            double totalsalario;
            return totalsalario = salario - salariocalculado;
        }*/
    }
}
