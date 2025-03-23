using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Contapp : IContaBancaria
    {
        private double _saldo;
        private int _numero;
        private string _tipo = "Poupança";

        public double Saldo
        {
            get {
                return _saldo;
            }
            set {
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
        public Contapp(int numero)
        {
             Numero = numero;
        }
        public void Depositar(double valor)
        {
            Saldo = valor * 1.05;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void ExibirSaldo(double valor)
        {
            Console.WriteLine($"\nSaldo da conta Poupança: R$ {Saldo:F2}");
        }

        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor não disponível para saque.");
            }
        }
    }

}
