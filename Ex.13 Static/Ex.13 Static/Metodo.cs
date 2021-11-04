using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13_Static
{
    public static class Metodos
    {
        public static bool ValidaNome(string nome)
        {
            if (nome.IndexOf(' ') != -1)
            {
                return true;
            }

            return false;
        }

        public static bool ValidaData(string data, out int idade)
        {
            DateTime dataNascimento = Convert.ToDateTime(data);

            if (dataNascimento > DateTime.Now)
            {
                idade = 0;
                return false;
            }
         
            idade = DateTime.Now.Year - dataNascimento.Year;
            return true;
        }
    }
}
