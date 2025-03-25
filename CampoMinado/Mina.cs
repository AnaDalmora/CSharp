using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado
{
    public class Mina : Campo
    {
        Random semente = new Random();
        

        public int[] gerarMina(int[] Minas)
        {
            
            for (int i = 0; i < Minas.Length; i++)
            {
                Minas[i] = semente.Next(0, 2); 
            }
            return Minas;
        }

    }
}
