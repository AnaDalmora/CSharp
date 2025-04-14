using CampoMinado;

public class Operacao
{
    Campo sistema = new Campo();
    Jogador jogador = new Jogador();
    Campo campoUsuario = new Campo();

    public void IniciarJogo()
    {
        sistema.GerarCampo();
        Jogar();
    }
    private void Jogar()
    {
        Tempo jogadorUm = new Tempo();
        Tempo jogadorDois = new Tempo();

        ExibirMensagemDeInicioDaRodada(1);
        jogador.JogarLoop(GerarCampoUsuario(), sistema, true, jogadorUm); // modo linha por linha

        ExibirMensagemDeInicioDaRodada(2);
        jogador.JogarLoop(GerarCampoUsuario(), sistema, false, jogadorDois); // Modo coluna por coluna

        Console.WriteLine($"\nO tempo de jogo do jogador 1 foi de {jogadorUm.TempoJogo()}");
        Console.WriteLine($"O tempo de jogo do jogador 2 foi de {jogadorDois.TempoJogo()}");
    }
    private Campo GerarCampoUsuario()
    {
        for (int i = 0; i < campoUsuario.linhas; i++)
        {
            campoUsuario.CampoMinado[i] = new string[campoUsuario.elementos]; 

            for (int j = 0; j < campoUsuario.elementos; j++)
            {
                campoUsuario.CampoMinado[i][j] = "X";
            }
        }
        return campoUsuario;
    }

    private void ExibirMensagemDeInicioDaRodada(int i)
    {
        Console.WriteLine($"Jogador {i} irá iniciar a jogada");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
