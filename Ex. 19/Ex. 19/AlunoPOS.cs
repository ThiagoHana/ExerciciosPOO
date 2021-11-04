using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._19
{
    class AlunoPOS : Aluno
    {
        public string FaculdadeFormacao { get; set; }

        public override string ToString()
        {
            return base.ToString() + "  - Faculdade: " + FaculdadeFormacao;
        }
    }
}