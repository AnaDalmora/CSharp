using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Listas
{
    internal class assistencia
    {
        public static int AskInt(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }
        public static string Ask(string pergunta)
        {
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }
        public static double AskDouble(string pergunta)
        {
            Console.WriteLine(pergunta);
            return double.Parse(Console.ReadLine());
        }
        public static void ShareVetorInt(int[] vetor)
        {
            foreach (int v in vetor)
            {
                Console.WriteLine(v);
            }
        }
        public static void ShareVetor(string[] vetor)
        {
            foreach (string v in vetor)
            {
                Console.WriteLine(v);
            }
        }
        public static void ShareList(List<string> list)
        {
            foreach(string v in list)
            {
                Console.Write(v +" ");
            }
            Console.WriteLine();
        }        
        public static void ShareListInt(List<int> list)
        {
            foreach(int v in list)
            {
                Console.Write(v+ " ");
            }
            Console.WriteLine();
        }
        public static void exibirVetor(int[] vetor)
        {
            Console.Write("[");
            foreach (int elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
            Console.Write("]");
        }

    }

}
