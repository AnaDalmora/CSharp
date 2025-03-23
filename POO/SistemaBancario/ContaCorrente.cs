using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class ContaCorrente : IContaBancaria
    {
        private int _numeroConta;
        private double _saldo;
        private string _titular;
        public ContaCorrente(int numeroConta, double saldo, string titular)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Titular = titular;
        }
        public int NumeroConta { get => _numeroConta; set => _numeroConta = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public string Titular { get => _titular; set => _titular = value; }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito realizado.");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível na conta corrente: R$ {Saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor + 5 <= Saldo) { Saldo -= valor + 5; } else { Console.WriteLine("Valor inválido."); }

        }
    }
}
