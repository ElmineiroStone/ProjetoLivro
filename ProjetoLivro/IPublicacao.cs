using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivro
{
    public interface IPublicacao
    {
        public void Abrir();
        public void Fechar();
        public void Folhear(int p);
        public void AvancarPag();
        public void VoltarPag();
    }
}
