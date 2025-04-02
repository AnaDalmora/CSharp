using System;
using System.Collections.Generic;

namespace CampoMinado
{
    public class Operacao 
    {
        public int chances = 10;

        public void IniciarJogo()
        {   
            Campo campo = new Campo();
            Grafico grafico = new Grafico();
            Regras regras = new Regras();

            campo.GerarCampos();
          

            while (!regras.Vencedor(campo.campoUsuario) && chances >0)
            {
                grafico.ExibirCampo(campo.campoUsuario, campo.linhas, campo.colunas); // Exibe o campo atual do usuário

                // Solicita a posição para abrir
                string abrir = SolicitarPosicao().ToLower();

                // Verifica se a posição escolhida é válida
                if (campo.campoUsuario.ContainsKey(abrir) && campo.campoUsuario[abrir] == "X")
                {
                    campo.campoUsuario[abrir] = campo.campoAberto[abrir];

                    // Se for uma mina ("1"), perde uma chance
                    if (campo.campoUsuario[abrir] == "1")
                    {
                        chances--;
                    }
                    else
                    {
                        AbrirVizinhos(abrir, campo);
                    }
                }
                else
                {
                    Console.WriteLine("\n\nPosição inválida! Tente novamente.");
                    Thread.Sleep(2000);
                }

                // Limpa a tela para a próxima iteração
                Console.Clear();
            }

            // Exibe o campo final quando o jogo termina
            grafico.ExibirCampo(campo.campoUsuario, campo.linhas, campo.colunas);

            if (regras.Vencedor(campo.campoUsuario)) 
            {
            } 
            else 
            {
            }
       
        }
        private string SolicitarPosicao()
        {
            Console.WriteLine($"\nVocê tem {chances} chances restantes.");
            Console.Write("Qual mina deseja desativar? (ex: a1): ");
            return Console.ReadLine();
        }
        private void AbrirVizinhos(string abrir, Campo campo)
        {
            // Extrai a coluna (letra) e a linha (número)
            char coluna = abrir[0];
            int linha = int.Parse(abrir.Substring(1));

            List<string> vizinhos = new List<string>
            {
                    $"{(char)(coluna - 1)}{linha}", // Esquerda
                    $"{(char)(coluna + 1)}{linha}", // Direita
                    $"{coluna}{linha - 1}", // Cima
                    $"{coluna}{linha + 1}" // Baixo
            };

            foreach (string vizinho in vizinhos)
            {
                if (campo.campoUsuario.ContainsKey(vizinho) && campo.campoUsuario[vizinho] == "X")
                {
                    campo.campoUsuario[vizinho] = campo.campoAberto[vizinho];
                }
            }
        }

        static void ImagemPerdedor()
        {
            Console.WriteLine("                    @@@@@@@@@@@@@@@@@@@                   `\r\n                 @@@@@@             @@@@@@@                \r\n              @@@@                       @@@@              \r\n             @@@                             @@            \r\n            @@                                @@           \r\n           @@                     `           @@          `\r\n          @@                                   @@          \r\n          @@ @@                             @@ @@          \r\n          @@ @@                             @@  @          \r\n          @@ @@                             @@  @          \r\n          @@  @@                            @@ @@          \r\n          @@  @@                           @@  @@          \r\n           @@ @@   @@@@@@@@     @@@@@@@@   @@ @@           \r\n            @@@@ @@@@@@@@@@     @@@@@@@@@@ @@@@@           \r\n             @@@ @@@@@@@@@@     @@@@@@@@@@ @@@             \r\n    @@@       @@  @@@@@@@@       @@@@@@@@@  @@      @@@@   \r\n   @@@@@     @@   @@@@@@@   @@@   @@@@@@@   @@     @@@@@@  \r\n  @@   @@    @@     @@@    @@@@@    @@@     @@    @@   @@  \r\n @@@    @@@@  @@          @@@@@@@          @@  @@@@    @@@ \r\n@@         @@@@@@@@       @@@@@@@       @@@@@@@@@        @@\r\n@@@@@@@@@     @@@@@@@@    @@@@@@@    @@@@@@@@      @@@@@@@@\r\n  @@@@ @@@@@      @@@@@              @@@ @@     @@@@@@ @@@ \r\n          @@@@@@  @@@  @@           @@  @@@  @@@@@@        \r\n              @@@@@@ @@ @@@@@@@@@@@ @@ @@@@@@              \r\n                  @@ @@ @ @ @ @ @ @ @ @ @@                 \r\n                @@@@  @ @ @ @ @ @ @ @   @@@@@              \r\n            @@@@@ @@   @@@@@@@@@@@@@   @@ @@@@@            \r\n    @@@@@@@@@@     @@                 @@      @@@@@@@@@    \r\n   @@           @@@@@@@             @@@@@@@@          @@   \r\n    @@@     @@@@@     @@@@@@@@@@@@@@@     @@@@@     @@@    \r\n      @@   @@@           @@@@@@@@@           @@@   @@      \r\n      @@  @@                                   @@  @@      \r\n       @@@@                                     @@@@       ");

        }
        static void ImagemVencedor() {
                Console.WriteLine("        ##########################          \r\n        ##########################          \r\n   #####################################    \r\n #########################################  \r\n####      ######################       #### \r\n###       ######################        ### \r\n##        ######################        ### \r\n###     ##########################      ### \r\n###    ############################    #### \r\n ###   ### #################### ###    ###  \r\n ####   ### ################## ####  ####   \r\n   ####  ######################### #####    \r\n    ######## ################ #########     \r\n      ######  ##############   ######       \r\n               ############                 \r\n                 ########                   \r\n                   ####                     \r\n                   ####                     \r\n                   ####                     \r\n                   ####                     \r\n               ############                 \r\n            ##################              \r\n            ##################              \r\n            ###            ###              \r\n            ###            ###              \r\n            ###            ###              \r\n            ##################              \r\n            ##################              \r\n          ######################            \r\n         ########################           ");
        }
       
    }
}
