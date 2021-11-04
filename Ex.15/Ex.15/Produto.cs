using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15
{
    class Produto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }

        public Categoria Categoria { get; set; }
    }
}
