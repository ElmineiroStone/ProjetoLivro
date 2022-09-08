using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivro
{
    public class Livro : IPublicacao
    {
        private string titulo;
        private string autor;
        private int totPaginas;
        private int pagAtual;
        private bool aberto;
        private Pessoa leitor;

        public string Detalhes()
        {
            return "Livro\n{" +
                "\n*" + " titulo = " + titulo + 
                "\n* autor = " + autor +
                "\n* totPaginas = " + totPaginas +
                "\n* pagAtual = " + pagAtual +
                "\n* aberto = " + aberto +
                "\n* leitor = " + leitor.Nome +
                "\n* idade = " + leitor.Idade +
                "\n* sexo = " + leitor.Sexo + "\n" + '}';
        }

        public void Abrir()
        {
            aberto = true;
        }

        public void Fechar()
        {
            aberto = false;
        }

        public void Folhear(int p)
        {
            if( p > totPaginas)
            {
                pagAtual = 0;
            }
            else
            {
                pagAtual = p;
            }
        }

        public void AvancarPag()
        {
            pagAtual++;
        }

        public void VoltarPag()
        {
            pagAtual--;
        }

        public Livro(string titulo, string autor, int totPaginas, Pessoa leitor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.totPaginas = totPaginas;
            this.aberto = false;
            this.pagAtual = 0;
            this.leitor = leitor;
        }
    }
}
