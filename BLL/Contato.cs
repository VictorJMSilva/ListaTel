using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Contato
    {
        public string Nome { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Nome} - {Telefone}";

        }
    }
}
