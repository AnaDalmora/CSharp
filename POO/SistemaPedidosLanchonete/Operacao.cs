using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidosLanchonete
{
    internal class Operacao
    {
        public List<Produto> produtos = new List<Produto> ();
        public List<Pedido> pedidos = new List<Pedido>();


        public int ExibirMenu()
        {
            Console.WriteLine("Digite o numero da operação que deseja executar: ");
            Console.WriteLine("0 - Sair\n1 - Adicionar Produto\n2 - Fazer Pedido\n3 - Exibir Cardapio\n4 - Exibir Pedidos");
            return int.Parse(Console.ReadLine());
        }
        public void ProcessamentoOperacao(int op)
        {
            switch (op) {
                case 0:
                    break;
                case 1:
                    AdicionarProduto();
                    break;
                case 2:
                    CriarPedido();
                    break;
                case 3:
                    ExibirCardapio(produtos);
                    break;
                case 4:
                    ExibirPedidos();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public void CriarPedido()
        {
            Pedido pedido = new Pedido();
            pedido.NumeroPedido = NPedido(pedidos);
            pedidos.Add(pedido);
            Cardapio(produtos);

            while(true)
            {
                Console.WriteLine("Qual item deseja pedir ? (digite o numero do item ou 0 para sair)");
                int item = int.Parse(Console.ReadLine());
                if(item == 0) {break;}
                pedido.AdicionarItens(item, produtos);
            }
            Console.Clear();
        }
        public void ExibirPedidos()
        {
            foreach(Pedido p in pedidos)
            {
                Console.WriteLine($"Pedido #{p.NumeroPedido}\n");
                p.ExibirItens();
                Console.WriteLine($"\nTotal: R$ {p.TotalPedido()}\n");
            }
            Retorno();
        }
        public void AdicionarProduto()
        {
            string r;
            do
            {
                Produto produto = new Produto();
                string nome;
                float preco;

                Console.Clear();
                Console.WriteLine("Insira o nome do produto");
                nome = Console.ReadLine();
                Console.WriteLine("Insira o valor do produto");
                preco = float.Parse(Console.ReadLine());

                produto.NomeProduto = nome;
                produto.Preco = preco;
                produtos.Add(produto);
                Console.WriteLine("Deseja adicionar outro produto? 0 para sair");
                r = Console.ReadLine();
            }while(r != "0");
            Console.Clear();

        }
        public void Cardapio(List<Produto> produtos)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("**** Itens Disponíveis ****");
            Console.WriteLine("***************************\n");
            for (int i = 0; i < produtos.Count(); i++)
            {
                Console.WriteLine($"{i + 1} - {produtos[i].NomeProduto} R$ {produtos[i].Preco}");
            }
        }
        public void ExibirCardapio(List<Produto>produtos)
        {
            Cardapio(produtos);
            Retorno();
        }

        static int NPedido(List<Pedido> pedidos)
        {
           int n = 0;
           foreach(Pedido p in pedidos)
            {
               if(p.NumeroPedido > n) { n = p.NumeroPedido; }
            }
            return n +1;
        }

        static void Retorno()
        {
            int r = -1;
            while(r != 0)
            {
                Console.WriteLine("0 para voltar");
                r = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        }

    }
}
