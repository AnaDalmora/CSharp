public class Grafico
{
    public void ExibirCampo(Campo campominado)
    {
        for (int i = 0; i < campominado.linhas; i++)
        {
            for (int j = 0; j < campominado.elementos; j++)
            {
                Console.Write(campominado.CampoMinado[i][j] + " ");
            }
            Console.WriteLine(); // Quebra de linha após imprimir cada linha
        }
    }
}