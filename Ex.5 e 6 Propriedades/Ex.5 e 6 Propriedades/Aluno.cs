using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5_e_6_Propriedades
{
    class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;

        public string PegaNome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha o nome corretamente!!");
                if (value.IndexOf(" ") == -1)
                    throw new Exception("Insira nome e sobrenome");
                else
                    nome = value;
            }
        }

        public double PegaNota1
        {
            get
            {
                return nota1;
            }
            set
            {
                if (value <= 0 || value > 10)
                    throw new Exception("Só valores maiores que zero!!");
                else
                    nota1 = value;
            }
        }

        public double PegaNota2
        {
            get
            {
                return nota2;
            }
            set
            {
                if (value <= 0 || value > 10)
                    throw new Exception("Só valores maiores que zero!!");
                else
                    nota2 = value;
            }
        }

        public double RetornaMedia
        {
            get
            {
                return (nota1 + nota2) / 2;
            }
        }
    }
}
