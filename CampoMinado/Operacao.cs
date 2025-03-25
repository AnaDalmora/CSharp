using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado
{
    internal class Operacao
    {
        int chances = 10;

        public Dictionary<string, string> CampoUsuario = new Dictionary<string, string>(); //campo onde o usuário vai abrindo as minas
        public void IniciarJogo()
        {
            Campo campo = new Campo();
            CampoUsuario = campo.GerarCampo();
            List<string> chaves = new List<string>(CampoUsuario.Keys);
            foreach (string chave in chaves)
            {
                CampoUsuario[chave] = "X";
            }
            Grafico grafico = new Grafico();

            while (chances > 0)
            {
                grafico.Exibicao(CampoUsuario);
                string abrir = CampoAbrir().ToLower();
                Dictionary<string, string> c = campo.CampoAbertoo();
                CampoUsuario[abrir] = c.GetValueOrDefault(abrir);
                if(c.GetValueOrDefault(abrir) == "1") { chances--; }
                Console.Clear();
                grafico.Exibicao(CampoUsuario);

            }
        }
       
        private string CampoAbrir()
        {
            Console.Write($"\n\nCaro soldado, qual mina deseja desativar?\nVocê tem {chances} chances\nR: ");
            return Console.ReadLine();
        }
        
    }
}
