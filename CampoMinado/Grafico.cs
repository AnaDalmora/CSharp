using System;
using System.Collections.Generic;
using System.Linq;

namespace CampoMinado
{  
    public class Grafico 
    {
       
        public void ExibirCampo(Dictionary<string, string> campoUsuario, int[] linhas,string[] colunas)
        {
            // Exibe o cabeçalho das colunas
            Console.Write("\t ");
            foreach (int linha in linhas)
            {
                // Alinha as colunas com 10 espaços de largura
                Console.Write(linha.ToString().PadRight(10));
            }
            Console.WriteLine("\n");

           
            foreach (string coluna in colunas)
            {
                Console.Write(coluna.PadRight(5) + "|   ");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(campoUsuario[$"{coluna}{i}"].PadRight(10));
                }
                Console.WriteLine("\n\n");
              

            }
        }
    }
}
