using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Contacc : IContaBancaria
    {
        private double _saldo;
        private int _numero;
        private string _tipo = "Corrente";

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }
        public String Tipo
        {
            get
            {
                return _tipo;
            }
        }
        public Contacc(int numero)
        {
            Numero = numero;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void ExibirSaldo(double valor)
        {
            Console.WriteLine($"\nSaldo conta Corrente: R$ {Saldo}.");
        }

        public void Sacar(double valor)
        {
            if (Saldo >= valor+5)
            {
                Saldo -= valor+5;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor não disponível para saque.");
            }
        }
    }
}
