using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class ContaPoupanca : IContaBancaria
    {
        private int _numeroConta;
        private double _saldo;
        private string _titular;

        public int NumeroConta { get => _numeroConta; set => _numeroConta = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public string Titular { get => _titular; set => _titular = value; }
        public ContaPoupanca(int numeroConta, double saldo, string titular)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Titular = titular;
        }

        public void Depositar(double valor)
        {
            Saldo += valor * 1.05;
            Console.WriteLine("Depósito realizado.");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível na conta Poupança: R$ {Saldo}");
        }
        public void Sacar(double valor)
        {
            if (valor <= Saldo) { Saldo -= valor; } else { Console.WriteLine("Valor inválido."); }
        }

    }
}
