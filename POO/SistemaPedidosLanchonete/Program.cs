namespace SistemaPedidosLanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacao operacao = new Operacao();
            int op;
            do
            {
                op = operacao.ExibirMenu();
                operacao.ProcessamentoOperacao(op);

            }while(op != 0);
         
        }
        
        
    }
}
