using System;
using System.Collections.Generic;

namespace CampoMinado
{
    internal class Operacao
    {
        private int chances = 10;
        private Dictionary<string, string> campoUsuario = new Dictionary<string, string>();
        private Dictionary<string, string> campoAberto = new Dictionary<string, string>();

        public void IniciarJogo()
        {
            Campo campo = new Campo();
            Grafico grafico = new Grafico();

            campo.GerarCampoAberto();
            campo.GerarCampoUsuario();

            campoAberto = campo.ObterCampoAberto();
            campoUsuario = campo.ObterCampoUsuario();

            while (chances > 0)
            {
                grafico.ExibirCampo(campoUsuario); // Exibe o campo atual do usuário

                // Solicita a posição para abrir
                string abrir = SolicitarPosicao().ToLower();

                // Verifica se a posição escolhida é válida
                if (campoUsuario.ContainsKey(abrir))
                {
                    campoUsuario[abrir] = campoAberto[abrir];

                    // Se for uma mina ("1"), perde uma chance
                    if (campoUsuario[abrir] == "1")
                    {
                        chances--;
                    }
                }
                else
                {
                    Console.WriteLine("Posição inválida! Tente novamente.");
                }

                // Limpa a tela para a próxima iteração
                Console.Clear();
            }

            // Exibe o campo final quando o jogo termina
            grafico.ExibirCampo(campoUsuario);
            Console.WriteLine("\r\n──▄────▄▄▄▄▄▄▄────▄───\r\n─▀▀▄─▄█████████▄─▄▀▀──\r\n─────██─▀███▀─██──────\r\n───▄─▀████▀████▀─▄────\r\n─▀█────██▀█▀██────█▀──\r\n\r\n");

        }

        private string SolicitarPosicao()
        {
            Console.WriteLine($"\nVocê tem {chances} chances restantes.");
            Console.Write("Qual mina deseja desativar? (ex: a1): ");
            return Console.ReadLine();
        }
    }
}
