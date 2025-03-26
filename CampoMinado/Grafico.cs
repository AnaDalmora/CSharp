using System;
using System.Collections.Generic;
using System.Linq;

namespace CampoMinado
{
    internal class Grafico
    {
        private string[] colunas = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        private int[] linhas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void ExibirCampo(Dictionary<string, string> campoUsuario)
        {
            // Exibe o cabeçalho das colunas
            Console.Write("\t ");
            foreach (int linha in linhas)
            {
                // Alinha as colunas com 10 espaços de largura
                Console.Write(linha.ToString().PadRight(10));
            }
            Console.WriteLine("\n");

            // Exibe as linhas de dados
            int a = 0;
            foreach (string coluna in colunas)
            {
                Console.Write(coluna.PadRight(5) + "|   ");

                for (int i = a; i < a + 10; i++)
                {
                    // Usamos a chave diretamente para acessar os valores
                    string chave = campoUsuario.Keys.ElementAt(i);
                    Console.Write(campoUsuario[chave].PadRight(10));
                }
                Console.WriteLine();
                a += 10;
            }
        }
    }
}
