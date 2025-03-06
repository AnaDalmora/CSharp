namespace SistemaPedidosLanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            AdicionarProduto("Batata-Frita", 10,produto1);
            Produto produto2 = new Produto();
            AdicionarProduto("Refrigerante", 5, produto2);
            Produto produto3 = new Produto();
            AdicionarProduto("X-Burguer", 20, produto3);
            Produto produto4 = new Produto();
            AdicionarProduto("X-Salada", 21, produto4);
            Produto produto5 = new Produto();
            AdicionarProduto("X-Egg", 22, produto5);
            Produto produto6 = new Produto();
            AdicionarProduto("X-Vegan", 23, produto6);
            Produto produto7 = new Produto();
            AdicionarProduto("Sorvete", 24, produto7);
            Produto produto8 = new Produto();
            AdicionarProduto("Agua", 25, produto8);

            Pedido pedido1 = new Pedido();
            pedido1.NumeroPedido = 1;
            pedido1.itens.Add(produto1);
            pedido1.itens.Add(produto2);
            pedido1.itens.Add(produto3);
            pedido1.ExibirPedido();

            Pedido pedido2 = new Pedido();
            pedido2.NumeroPedido = 2;
            pedido2.itens.Add(produto4);
            pedido2.itens.Add(produto5);
            pedido2.itens.Add(produto6);
            pedido2.ExibirPedido();
        }
        static void AdicionarProduto(string nome, float valor, Produto produto)
        {
            produto.NomeProduto = nome;
            produto.Preco = valor;
        }
        
    }
}
