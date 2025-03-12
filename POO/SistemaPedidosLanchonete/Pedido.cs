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
        public List<Produto> itens = new List<Produto>();
        
        public void AdicionarItens(int item, List<Produto> produtos)
        {
            itens.Add(produtos[item - 1]);
        }

        public void ExibirItens()
        {
            for (int i =0; i<itens.Count();i++)
            {
                Console.WriteLine($"{i+1} - {itens[i].NomeProduto} R$ {itens[i].Preco}");
            }
        }
        public float TotalPedido()
        {
            float soma =0;
            foreach(Produto p in itens)
            {
                soma += p.Preco;
            }
            return soma;
        }
    }
}
