using System;

namespace CampoMinado
{
    public class Mina
    {
        private Random random = new Random();
        private int[] minas = new int[100]; // Representa as minas
        public int[] GerarMina()
        {
            for (int i = 0; i < minas.Length; i++)
            {
                minas[i] = random.Next(0, 2); // 0 = sem mina, 1 = com mina
            }
            return minas;
        }
       
    }
}
