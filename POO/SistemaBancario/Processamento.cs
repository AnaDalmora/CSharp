
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaBancario
{
    internal class Processamento
    {
        
        private List<Contacc> _contacc = new List<Contacc>();
        private List<Contapp> _contapp = new List<Contapp>();

        public void ExibirMenuInicial()
        {
            Console.WriteLine("\t\tBem vindo ao banco da Ana.\n\n\n");
            Console.WriteLine("Qual operação deseja realizar?\n\n");
            Console.Write("0 - Sair\n1 - Criar Conta\n2 - Verificar Saldo Conta\n3 - Sacar\n4 - Depositar\n5 - Encerrar Conta\n------------\nR: ");
        }
        public void processamentoOperacao(int op)
        {
            switch (op)
            {
                case 0:
                    return;
                case 1:
                    CriarConta();
                    break;
                case 2:
                    VerificarSaldo(_contacc,_contapp);
                    break;
                case 3:
                    Sacar(_contacc, _contapp);
                    break;
                case 4:
                    Depositar(_contacc, _contapp);
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
        }
        private void CriarConta()
        {
            int numero = gerarNConta(_contacc);
            Contapp contapp = new Contapp(numero);
            Contacc contacc = new Contacc(numero);
     
            _contacc.Add(contacc);
            _contapp.Add(contapp);

            Console.WriteLine($"\n\nConta criada com sucesso! o numero da sua conta é {contacc.Numero}");
        }

        private void VerificarSaldo(List<Contacc> _contacc,List<Contapp>_contapp)
        {
            Console.Write("Insira o numero da conta:\n--------\n\nR: ");
            int numero = int.Parse(Console.ReadLine());

            Contacc corrente = _contacc.FirstOrDefault(c => c.Numero == numero);
            Contapp poupanca = _contapp.FirstOrDefault(c => c.Numero == numero);

            if (corrente != null && poupanca != null)
            { 
                Console.WriteLine($"Saldo da conta Corrente: R$ {corrente.Saldo}");
                Console.WriteLine($"Saldo da conta Poupança: R$ {poupanca.Saldo}");
            }
            else
            {
                Console.WriteLine("Conta não encontrada!");
            }

        }

        private void Sacar(List<Contacc> _contacc, List<Contapp> _contapp)
        {
            Console.Write("Insira o numero da conta\n------\nR:");
            int numero = int.Parse(Console.ReadLine());

            Contacc c = _contacc.FirstOrDefault(c => c.Numero == numero);
            Contapp p = _contapp.FirstOrDefault(p => p.Numero == numero);
            if (c != null && p != null) {
                Console.Write("Qual Conta deseja Sacar?\n\n1 - Corrente\n2 - Poupança\n--------\n\nR: ");
                string resp = Console.ReadLine();
                Console.WriteLine("Qual valor deseja sacar? ");
                double valor = double.Parse(Console.ReadLine());
                if(resp == "1"){ c.Sacar(valor);}else{p.Sacar(valor);}
            }
            else
            {
                Console.WriteLine("Conta inválida.");
            }
        }
        private void Depositar(List<Contacc> _contacc, List<Contapp> _contapp)
        {
            Console.Write("Insira o numero da conta\n------\nR:");
            int numero = int.Parse(Console.ReadLine());

            Contacc c = _contacc.FirstOrDefault(c => c.Numero == numero);
            Contapp p = _contapp.FirstOrDefault(p => p.Numero == numero);
            if (c != null && p != null)
            {
                Console.Write("Qual Conta deseja Depositar?\n\n1 - Corrente\n2 - Poupança\n--------\n\nR: ");
                string resp = Console.ReadLine();
                Console.WriteLine("Qual valor deseja Depositar? ");
                double valor = double.Parse(Console.ReadLine());
                if (resp == "1") { c.Depositar(valor); } else { p.Depositar(valor); }
            }
            else
            {
                Console.WriteLine("Conta inválida.");
            }
        }






        //----------------Funções estaticas
        static int gerarNConta(List<Contacc> _contas) {
            int max = 0;
            foreach(Contacc item in _contas)
            {
                if (item.Numero > max)
                {
                    max = item.Numero;
                }
            }
            return max + 1;
        }

    }
}