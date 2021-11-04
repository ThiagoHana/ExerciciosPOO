using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2_Jogo_Encapsulado
{
    class jogo
    {
        private int codigo;
        private string nome;
        private string categoria;
        private DateTime lancamento;

        public void SetPedeCodigo(int codigo)
        {
            if (codigo <= 0)
                throw new Exception("Digite valores positivos!!");
            else
                this.codigo = codigo;
        }

        public int GetRetornaCodigo()
        {
            return codigo;
        }

        public void SetPedeNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Nome obrigatório!!");
            else
                this.nome = nome;
        }

        public string GetRetornaNome()
        {
            return nome;
        }

        public void SetPedeCategoria(string categoria)
        {
            if (categoria == "ação" || categoria == "luta" || categoria == "tiro" || categoria == "esportes")
                this.categoria = categoria;
            else
                throw new Exception("Digite uma das categorias do programa!!");
        }

        public string GetRetornaCategoria()
        {
            return categoria;
        }

        public void SetPedeLancamento(DateTime lancamento)
        {
            if (lancamento > DateTime.Now)
                throw new Exception("Ta prevendo o futuro ?");
            else
                this.lancamento = lancamento;
        }

        public DateTime GetRetornaLancamento()
        {
            return lancamento;
        }

        public string Atributos()
        {
            return $"-Codigo: {GetRetornaCodigo()} \n-Nome: {GetRetornaNome()} \n-Categoria: {GetRetornaCategoria()} \n-Data de Lançamento: {GetRetornaLancamento().ToShortDateString()}";
        }
    }
}
