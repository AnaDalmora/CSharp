using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado
{
    internal class Grafico
    {
        private string[] colunas = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        private int[] linhas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void Exibicao(Dictionary<string, string> CampoUsuario)
        {
            // Exibe o cabeçalho das colunas
            Console.Write("\t ");
            foreach (string coluna in colunas)
            {
                // Alinha as colunas com 10 espaços de largura
                Console.Write(coluna.PadRight(10));
            }
            Console.WriteLine("\n");

            // Exibe as linhas de dados
            int a = 0;
            foreach (int linha in linhas)
            {
                Console.Write(linha.ToString().PadRight(5) + "|   ");

                for (int i = a; i < a + 10; i++)
                {
                    Console.Write(CampoUsuario.Values.ElementAt(i).PadRight(10));

                }
                Console.WriteLine(); 
                a += 10; 
            }
        }



    }
}
