public class Campo
{
    // Define a quantidade de linhas (altura) do campo
    private int _linhas = 13;
    // Define a quantidade de elementos (colunas) por linha (largura do campo)
    private int _elementos = 10;
    // Matriz que representa o campo minado (0 = livre, 1 = mina)
    private string[][] _campominado;
    private Mina mina = new Mina();

    //acesso externo
    public string[][] CampoMinado => _campominado;
    public int linhas => _linhas;
    public int elementos => _elementos;

    public Campo()
    {
        _campominado = new string[_linhas][];
    }

    // Gera o campo minado preenchendo com minas (1) ou espaços livres (0)
    public string[][] GerarCampo()
    {
        for (int i = 0; i < _linhas; i++)
        {
            string[] linha = new string[_elementos];

            for (int j = 0; j < _elementos; j++)
            {
                linha[j] =  mina.GerarMina().ToString(); // 0 = livre, 1 = mina
            }
            _campominado[i] = linha;
        }
        return CampoMinado;
    }
}
