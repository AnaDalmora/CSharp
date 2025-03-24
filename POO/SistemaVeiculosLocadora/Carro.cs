
namespace SistemaVeiculosLocadora
{
    public class Carro : Veiculos
    {
        public Carro(string modelo, string marca, int ano, double valorbasediarioaluguel) : base(modelo, marca, ano, valorbasediarioaluguel)
        {
        }
        public double CalcularAluguel(int dias)
        {
            return dias * ValorBaseDiarioAluguel;
        }
    }
}
