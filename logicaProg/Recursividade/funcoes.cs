using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class funcoes
    {
       public static int AskInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }
        public static int Potencia(int a, int b)
        {
            if (b == 1) return a * 1;
            return a * Potencia(a, b - 1);
        }
        public static double Soma(int n)
        {
            if (n == 0) return 0;
            return n + Soma(n - 1);
        }
        public static void ContagemRegressiva(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(n);
                ContagemRegressiva(n - 1);
            }
        }
        public static void Fibonacci(int termo1,int termo2, int n)
        {
            if (n !=0 )
            {
                Console.WriteLine(termo1);
                Fibonacci(termo2, termo1 + termo2, n - 1);
            }
        }

        public static void MDC(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("O MDC é "+a);
            }
            else 
            {
                MDC(b, a % b);
            }
        }

    }
}
