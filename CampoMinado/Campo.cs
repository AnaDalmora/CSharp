using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado
{
    public class Campo
    {
        private string[] colunas = new string[] {"a","b","c","d","e","f","g","h","i","j"};
        private int[] linhas = new int[] {1,2,3,4,5,6,7,8,9,10};
        int[] Minas = new int[100];
        private Dictionary<string, string> CampoAberto = new Dictionary<string, string>(); //campo onde as minas estão visiveis
        
        public Dictionary<string, string> GerarCampo()
        {
           Mina mina = new Mina();
           Minas = mina.gerarMina(Minas);
           foreach(string coluna in colunas)
           {
                int i = 0;
                foreach(int linha in linhas)
                {
                    string key = coluna + Convert.ToString(linha);
                    string value = Convert.ToString(Minas[i + linha]);
                    CampoAberto.Add(key,value);
                }
                i += 10;
           }
           return CampoAberto;
        }
        public Dictionary<string, string> CampoAbertoo()
        {
            return CampoAberto;
        }
    }
   
}
