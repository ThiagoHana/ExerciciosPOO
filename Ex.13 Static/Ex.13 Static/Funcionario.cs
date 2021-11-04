using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13_Static
{
    public enum Sexo { Masculino, Feminino }
    public enum EstadoCivil { Casado, Solteiro, Viúvo }

    public class Funcionario
    {
        public Funcionario(string nome, DateTime nascimento, Sexo sexo, EstadoCivil estadoCivil)
        {
            Nome = nome;
            DataNascimento = nascimento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
    }
}
