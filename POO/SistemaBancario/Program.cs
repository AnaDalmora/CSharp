namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Processamento processamento = new Processamento();
                processamento.ExibirMenuInicial();
                int op = int.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 0) {break;}
                processamento.processamentoOperacao(op);
            }
        }
    }
}
