using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10_Construtores1
{
    class ContaCorrente
    {
        private int agencia;
        private string conta;
        private string nome;
        public double Saldo { get; private set; }
        
        public int Agencia { get => agencia; set => agencia = value; }
        public string Conta { get => conta; set => conta = value; }
        public string Nome { get => nome; set => nome = value; }

        public ContaCorrente(int agencia, string conta, string nome)
        {
            Agencia = agencia;
            Conta = conta;
            Nome = nome;
            Saldo = 0;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if(Saldo-valor < 0)
            {
                throw new Exception("Saldo mão pode ser negativo!!");
            }
            Saldo -= valor;
        }
    }
}
