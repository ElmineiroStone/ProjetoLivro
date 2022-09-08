using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivro
{
    public class Pessoa
    {
        public void FazerAniversario()
        {
            this.Idade++;
        }

        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public string Nome { get; set; }
        public int Idade { get; private set; }
        public string Sexo { get; set; }
    }
}
