using System;
using System.Collections.Generic;

namespace CampoMinado
{
    public class Campo
    {
        private string[] colunas = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        private int[] linhas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private Dictionary<string, string> campoAberto = new Dictionary<string, string>(); // Onde as minas estão visíveis
        private Dictionary<string, string> campoUsuario = new Dictionary<string, string>(); // Onde o campo não é visível

        // Gera o campo com a distribuição das minas
        public void GerarCampoAberto()
        {
            Mina mina = new Mina();
            int[] minas = mina.GerarMina(); // Gera as minas

            int a = 0;
            foreach (string coluna in colunas)
            {
                foreach (int linha in linhas)
                {
                    string chave = coluna + Convert.ToString(linha);
                    campoAberto.Add(chave, Convert.ToString(minas[a]));
                    a++;
                }
            }
        }

        // Inicializa o campo do usuário com valores "X" para as posições
        public void GerarCampoUsuario()
        {
            int a = 0;
            foreach (string coluna in colunas)
            {
                foreach (int linha in linhas)
                {
                    string chave = coluna + Convert.ToString(linha);
                    campoUsuario.Add(chave, "X");
                    a++;
                }
            }
        }

        public Dictionary<string, string> ObterCampoAberto()
        {
            return campoAberto;
        }

        public Dictionary<string, string> ObterCampoUsuario()
        {
            return campoUsuario;
        }
    }
}
