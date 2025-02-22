using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class funções
    {
        public static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] SumMatriz(int linhas,int colunas,int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizC = new int[linhas,colunas];
            for (int i = 0; i < linhas; i++) { 
                for (int j = 0; j < colunas; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            return matrizC;
        }
        public static double SumMatrizunica(int linhas, int colunas, int[,] matrizA)
        {
            double soma = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    soma += matrizA[i, j];
                }
            }
            return soma;
        }
        public static List<int> MaioreMenor(int[,] matriz) {
            int menor = matriz[0,0]; 
            int maior =  matriz[0, 0];

            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maior) maior = matriz[i, j];
                    if (matriz[i, j] < menor) menor = matriz[i, j];
                }
            }
            List<int> valores = new List<int> { menor, maior };
            return valores; 

        }
        public static void DiagonalPrincipal(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("  ");
                    if (i == j) Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static int[,] Transposta(int[,] matriz)
        {
            int[,] matrizTransposta = new int[3, 3];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizTransposta[j, i] = matriz[i, j];
                }
            }
            return matrizTransposta;
        }
        public static bool VerificaIdentidade(int[,] matriz)
        {
            bool identidade = true;
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (matriz[i,j] != 1)
                        {
                            identidade = false;
                        }
                    }
                    else
                    {
                        if (matriz[i, j] != 0)
                        {
                            identidade = false;
                        }
                    }
                
                   
                }
            }
            return identidade;
        }
        public static int[,] MultiplicacaoMatriz(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizMultiplicada = new int[2, 2];
         
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizMultiplicada[i, j] = 0;
                    for (int k = 0; k < matrizB.GetLength(1); k++)
                    {
                        matrizMultiplicada[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }
            return matrizMultiplicada;
        }
        public static int[] MatrizEsparsa(int[,] matriz)
        {
            int nulos = 0;
            int notNulos = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] == 0)
                    {
                        nulos++;
                    }
                    else
                    {
                        notNulos++;
                    }
                }
            }
            return new int[] { nulos, notNulos };
        }
        public static int[,] MatrizDinamica()
        {
            Console.WriteLine("Qual a quantidade de linhas da matriz");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de colunas da matriz");
            int colunas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[linhas,colunas];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Qual o elemento da posição A[{i},{j}]");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matriz;
        }
    }

}
