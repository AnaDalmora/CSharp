using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Listas
{
    internal static class matematica
    {
        public static int soma(int[] num)
        {
            int soma = 0;
            foreach (int i in num)
            {
                soma += i;
            }
            return soma;
        }
        public static double Media(int[] num)
        {
            return soma(num)/num.Length;
        }
        public static double[] MaioreMenor(double[] num)
        {
            double greater = double.MinValue; 
            double minor = double.MaxValue;  

            foreach (double i in num)
            {
                if (i > greater) greater = i; 
                if (i < minor) minor = i;    
            }

            return new double[] { greater, minor }; 
        }
        public static bool BuscaValor(double[] num, double n)
        {
            if(Array.Exists(num, element => element == n)) return true;

            return false;
        }
        public static int [][] PrimosandNotPrimos(int[] num)
        {
             List <int> primos = new List <int>();
             List <int> Notprimos = new List<int>();

            foreach (int i in num)
            {
                if (EhPrimo(i))
                {
                    primos.Add(i);
                }
                else
                {
                    Notprimos.Add(i);
                }

            }
            return new int[][] {primos.ToArray(), Notprimos.ToArray()};
        }
        static bool EhPrimo(int n)
        {
            int verificaPrimo = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    verificaPrimo++;
                }
            }
            if (verificaPrimo > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string InverterVetor(string[] palavra)
        {
            string palavraInvertida = "";
            for(int i = palavra.Length-1; i>= 0; i--)
            {
                palavraInvertida += palavra[i];
                Console.WriteLine(palavraInvertida);
            }
            return palavraInvertida;
        }
        public static int Sum(int n)
        {
            List<int> numeros = new List<int> ();
            for (int i =0; i<n; i++)
            {
                numeros.Add(assistencia.AskInt("Insira um número"));
            }
            return numeros.Sum();
        }
        public static int Maior(List<int> numeros)
        {
            return numeros.Max();
        }       
        public static List<string> Remover(List<string> frutas, string itemRemovido)
        {
            foreach(string item in frutas)
            {
                frutas.Remove(itemRemovido);
                break;
            }
            return frutas;
        }        
        public static List<int> numerosMaior50(List<int> numeros)
        {
             List<int> numerosMaiores50 = new List<int> ();

            foreach(int item in numeros)
            {
                if (item >50) numerosMaiores50.Add(item);
            }
            return numerosMaiores50;
        }
        public static bool NomePresente(List<string>nomes, string nome)
        {
            foreach (string item in nomes)
            {
                if (item == nome) return true;

            }
            return false;
        }

        public static int ContagemNumero(int[] vetor, int n)
        {
            int qtd = 0;
            foreach(int elemento in vetor)
            {
                if (elemento == n)
                {
                    qtd++;
                }
            }
            return qtd;
        }
       
        public static int [] MescladeVetores(int[] vetorA, int[] vetorB)
        {
            int[] vetorC = new int[vetorA.Length + vetorB.Length];
            int posicao = 0;

            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorC[i] = vetorA[i];
                posicao++;
            }            
            for (int i = 0; i < vetorB.Length; i++)
            {
                vetorC[posicao] = vetorB[i];
                posicao++;
            }

            Array.Sort(vetorC);

            return vetorC;
        }
        
    }

}
