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
                    break;
                case 3:
                    ExibirCardapio(produtos);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public void AdicionarProduto()
        {
            string r;
            do
            {
                Produto produto = new Produto();
                string nome;
                float preco;

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
        public void ExibirCardapio(List<Produto>produtos)
        {
            int r = 1;
            Console.WriteLine("***************************");
            Console.WriteLine("**** Itens Disponíveis ****");
            Console.WriteLine("***************************\n");
            for(int i = 0; i < produtos.Count();i++)
            {
                Console.WriteLine($"{i + 1} - {produtos[i].NomeProduto} R$ {produtos[i].Preco}");
            }
            while(r != 0)
            {
                Console.WriteLine("0 para voltar");
                r = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        }

        
    }
}
