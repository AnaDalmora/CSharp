using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidosLanchonete
{
    public class Pedido
    {
        public int NumeroPedido;
        public List<Produto> itens = new List<Produto> ();
        

        public void ExibirPedido()
        {
            Console.WriteLine($"\nPedido #{NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach(var item in itens)
            {
                Console.WriteLine($"- {item.NomeProduto} - R$ {item.Preco}");
            }
            Console.WriteLine($"Total: R$ {CalcularValorTotalPedido()}");
        }
        public float CalcularValorTotalPedido()
        {
            float totalPedido = 0;
            foreach(var item in itens)
            {
                totalPedido += item.Preco;
            }
            return totalPedido;
        }
        
    }
}
