namespace SistemaVeiculosLocadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caminhao caminhaoBau = new Caminhao("Atego", "Mercedes-Benz", 2023, 500);
            Moto motoBiz = new Moto("Biz", "Honda", 2024, 100);
            Carro carrogol = new Carro("Gol", "Volkswagen", 2023, 200);

            Console.WriteLine($"Veiculo: {caminhaoBau.Modelo} | Marca: {caminhaoBau.Marca} | Ano: {caminhaoBau.Ano} | " +
                $"Custo por 5 dias: {caminhaoBau.CalcularAluguel(5)}");

            Console.WriteLine($"Veiculo: {motoBiz.Modelo} | Marca: {motoBiz.Marca} | Ano: {motoBiz.Ano} | " +
               $"Custo por 5 dias: {motoBiz.CalcularAluguel(5)}");

            Console.WriteLine($"Veiculo: {carrogol.Modelo} | Marca: {carrogol.Marca} | Ano: {carrogol.Ano} | " +
               $"Custo por 5 dias: {carrogol.CalcularAluguel(5)}");


        }
    }
}
