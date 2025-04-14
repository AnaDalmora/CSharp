using System;
using System.Diagnostics; 
using System.Threading;   
using CampoMinado;

public class Jogador
{
    private Grafico grafico = new Grafico();
    private Regra regra = new Regra();

    public void JogarLoop(Campo usuario, Campo sistema, bool porLinha, Tempo jogador)
    {   
        jogador.start = DateTime.Now;
        int linhas = usuario.linhas;
        int colunas = usuario.elementos;
        
        //jogador quer jogar por linhas? sim: linhas como for externo, não: colunas como for externo
        int externo = porLinha ? linhas : colunas;
        //jogador quer jogar por linhas? sim: colunas como for interno, não: linhas como for interno
        int interno = porLinha ? colunas : linhas;

        for (int i = 0; i < externo; i++)
        {
            for (int j = 0; j < interno; j++)
            {
                // Converte para coordenadas com base no modo do jogo
                int linha = porLinha ? i : j;
                int coluna = porLinha ? j : i;

                if (usuario.CampoMinado[linha][coluna] == "X")
                {
                    // Abre a posição no campo do usuário com base no campo original
                    usuario.CampoMinado[linha][coluna] = sistema.CampoMinado[linha][coluna];
                    AbreVizinhos(usuario, sistema, linha, coluna);

                    Console.WriteLine($"Posição aberta [{linha},{coluna}], elemento aberto {usuario.CampoMinado[linha][coluna]}\n");
                    grafico.ExibirCampo(usuario);

                    Thread.Sleep(1500); // Espera 1,5 segundo para o jogador ver a jogada

                    // Verifica se caiu em uma mina
                    if (regra.verificaMina(usuario.CampoMinado[linha][coluna]))
                    {
                        jogador.finish = DateTime.Now;
                        return;
                    }
                    Console.Clear();
                    Thread.Sleep(500);
                }
            }
        }
    }
    
    private void AbreVizinhos(Campo usuario, Campo sistema, int i, int j)
    {
        int linhas = usuario.linhas;
        int colunas = usuario.elementos;

        // Direções para os 8 vizinhos ao redor da célula (i, j)
        int[,] direcoes = new int[,]
        {
            {-1, -1}, {-1, 0}, {-1, 1},
            { 0, -1},          { 0, 1},
            { 1, -1}, { 1, 0}, { 1, 1}
        };

        // Percorre cada direção e revela a célula vizinha, se estiver dentro dos limites
        for (int d = 0; d < 8; d++)
        {
            int novoI = i + direcoes[d, 0];
            int novoJ = j + direcoes[d, 1];

            if (novoI >= 0 && novoI < linhas && novoJ >= 0 && novoJ < colunas)
            {
                usuario.CampoMinado[novoI][novoJ] = sistema.CampoMinado[novoI][novoJ];
            }
        }
    }
}
