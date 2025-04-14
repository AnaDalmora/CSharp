public class Mina { 

    Random random = new Random();

    public int GerarMina()
    {
        // 80% de aparecer 0 e 15% de aparecer 1. 0 = sem mina, 1 = mina
        return random.NextDouble() < 0.15 ? 1 : 0;
    }
}
