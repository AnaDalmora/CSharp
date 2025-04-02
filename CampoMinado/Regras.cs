using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado
{
    internal class Regras
    {
        public bool Vencedor(Dictionary<string, string> campoUsuario) {
            if (campoUsuario.ContainsValue("X")) { return false; }
            return true;
        }
        
    }
}
