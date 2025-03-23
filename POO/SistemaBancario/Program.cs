namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ContaCorrente> contaCC = new List<ContaCorrente> { };
            List<ContaPoupanca> contaPP = new List<ContaPoupanca> { };
            Operacao operacao = new Operacao();

            while (true)
            {
                Console.Clear();
                operacao.MenuBemVindo();
                int op = int.Parse(Console.ReadLine());
                if (op == 2)
                {
                    Cadastro cadastro = new Cadastro();
                    cadastro.CriarConta(contaCC, contaPP);
                    operacao.retorno();
                }
                else if (op == 1)
                {
                    Console.Clear();
                    int enderecoConta = acharConta(contaCC);
                    if (enderecoConta != -1)
                    {
                        Console.Clear();
                        while (true)
                        {
                            operacao.ListarOperacoes(contaCC[enderecoConta], enderecoConta, contaPP[enderecoConta]);
                            int ope = int.Parse(Console.ReadLine());
                            if (ope == 0) { break; }
                            operacao.ProcessarOperacao(contaCC[enderecoConta], enderecoConta, ope, contaPP[enderecoConta]);
                        }
                    }
                }
                else if (op == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Operação inválida");
                }

            }
        }
        static int acharConta(List<ContaCorrente> contaCC)
        {
            Console.Write("Qual o numero da sua conta?\n-----\nR: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < contaCC.Count(); i++)
            {
                if (contaCC[i].NumeroConta == numero)
                {
                    return i;
                }
            }
            Console.WriteLine("Conta não encontrada.");
            return -1;
        }

    }
}
