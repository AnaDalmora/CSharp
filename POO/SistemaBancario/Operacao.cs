using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Operacao
    {
        public void MenuBemVindo()
        {
            Console.WriteLine("\t\tBem Vind@!\n\n");
            Console.WriteLine("Por gentileza, selecione uma das opções.\n");
            Console.Write("\n0 - Sair\n1 - Já sou cliente\n2 - Criar Cadastro\n-----\nR: ");
        }


        public void ListarOperacoes(ContaCorrente contacc, int endereco, ContaPoupanca contapp)
        {
            Console.WriteLine($"Olá {contacc.Titular}!\n\nQual operacao deseja realizar?\n");
            Console.Write("1 - Verificar Saldo\n2 - Sacar\n3 - Depositar\n0 - Sair\n-------\nR: ");

        }
        public void ProcessarOperacao(ContaCorrente contacc, int endereco, int op, ContaPoupanca contapp)
        {
            Console.Clear();
            switch (op)
            {
                case 0:
                    return;
                case 1:
                    contacc.ExibirSaldo();
                    contapp.ExibirSaldo();
                    break;
                case 2:
                    Sacar(contacc, endereco, contapp);
                    break;
                case 3:
                    Depositar(contacc, endereco, contapp);
                    break;
                default:
                    Console.WriteLine("Operacao inválida!");
                    break;
            }
            retorno();
        }
        private void Sacar(ContaCorrente contacc, int endereco, ContaPoupanca contapp)
        {
            Console.Write("Qual conta deseja Sacar?\n1 - Corrente\n2 - Poupança\n-----\nR: ");
            int op = int.Parse(Console.ReadLine());

            Console.Write("\nQual valor deseja sacar?\nR: ");
            double valor = double.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    contacc.Sacar(valor);
                    break;
                case 2:
                    contapp.Sacar(valor);
                    break;
                default:
                    Console.WriteLine("Conta inválida.");
                    break;
            }

        }
        private void Depositar(ContaCorrente contacc, int endereco, ContaPoupanca contapp)
        {
            Console.Write("Qual conta deseja depositar?\n1 - Corrente\n2 - Poupança\n-----\nR: ");
            int op = int.Parse(Console.ReadLine());

            Console.Write("\nQual valor deseja depositar?\nR: ");
            double valor = double.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    contacc.Depositar(valor);
                    break;
                case 2:
                    contapp.Depositar(valor);
                    break;
                default:
                    Console.WriteLine("Conta inválida.");
                    break;
            }

        }
        public void retorno()
        {
            while (true)
            {
                Console.Write("\n\n0 para voltar\n------\nR:");
                string r = Console.ReadLine();
                if (r == "0")
                {
                    Console.Clear();
                    break;
                }
            }
        }

    }
}
