    using System;
    using System.Collections.Generic;

    namespace CampoMinado
    {
        public class Campo : Mina
        {
            public string[] colunas = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            public int[] linhas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            public Dictionary<string, string> campoAberto = new Dictionary<string, string>(); // Onde as minas estão visíveis
            public Dictionary<string, string> campoUsuario = new Dictionary<string, string>(); // Onde o campo não é visível

            // Gera o campo com a distribuição das minas
            public void GerarCampos()
            {
                Mina mina = new Mina();
                mina.GerarMina();
                int index = 0;
                foreach (var coluna in colunas)
                {
                    foreach (var linha in linhas)
                    {
                        campoAberto.Add($"{coluna}{linha}", mina.minas[index++].ToString());
                        campoUsuario.Add($"{coluna}{linha}", "X");
                    }
                }
            
            }
           
         }
    }
