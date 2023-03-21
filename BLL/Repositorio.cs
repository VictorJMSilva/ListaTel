using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
        public List<Contato> Contatos { get; set; } = new List<Contato>() { };

        public void Incluir (Contato num)
        {
            Contatos.Add(num);
        }

        public void Remover(Contato num)
        {
            Contatos.Remove(num);
        }
    }
}
