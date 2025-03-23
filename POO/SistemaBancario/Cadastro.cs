using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Cadastro
    {
        public void CriarConta(List<ContaCorrente> contaCC, List<ContaPoupanca> contaPP)
        {
            Console.Write("Por gentileza insira o nome do titular da conta:\n-----\nNome: ");
            string nome = Console.ReadLine();
            int numero = gerarNumeroConta(contaCC);
            ContaCorrente contacc = new ContaCorrente(numero, 0.00, nome);
            ContaPoupanca contapp = new ContaPoupanca(numero, 0.00, nome);
            contaCC.Add(contacc);
            contaPP.Add(contapp);
            Console.WriteLine($"\nParabens, sua conta foi criada! O numero da sua conta é {numero}");
        }
        public int gerarNumeroConta(List<ContaCorrente> contaCC)
        {
            int max = 0;
            foreach (ContaCorrente c in contaCC)
            {
                if (c.NumeroConta > max) { max = c.NumeroConta; }
            }

            return max + 1;
        }

    }
}
