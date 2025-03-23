using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal interface IContaBancaria
    {

        public void Sacar(double valor);
        public void Depositar(double valor);
        public void ExibirSaldo(double valor);
    }
}
