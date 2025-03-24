

namespace SistemaVeiculosLocadora
{
    public class Veiculos : IVeiculos
    {
        private string _modelo;
        private string _marca;
        private int _ano;
        private double _ValorBasediarioAluguel;

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public double ValorBaseDiarioAluguel
        {
            get { return _ValorBasediarioAluguel; }
            set { _ValorBasediarioAluguel = value; }
        }

        public Veiculos (String modelo, string marca,int ano,double valorbasediarioaluguel) {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorBaseDiarioAluguel = valorbasediarioaluguel;
        }

        public void CalcularAluguel(int dias) { }
       
    }
}
