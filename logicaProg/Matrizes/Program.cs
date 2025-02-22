using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercicio01();
            exercicio02();
            exercicio03();
            exercicio04();
            exercicio05();
            exercicio06();
            exercicio07();
            exercicio08();
            exercicio09();
            exercicio10();
           
        }
        static void exercicio01()
        {
            int[,] matriz =
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 6, 7, 8, }
            };
            //1.Criando uma Matriz. Declare e inicialize uma matriz 3x3 com valores inteiros e imprima seus elementos.
            funções.ImprimirMatriz(matriz);
        }
        static void exercicio02()
        {
            //2. Soma dos Elementos
            //Crie um programa que percorre uma matriz e calcula a soma de todos os seus elementos.
            int[,] matrizA =
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 6, 7, 8, }
            };
            int[,] matrizB =
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 6, 7, 8, }
            };
            Console.WriteLine("Matriz A\n");
            funções.ImprimirMatriz(matrizA);
            Console.WriteLine("Matriz B\n");
            funções.ImprimirMatriz(matrizB);
            Console.WriteLine("A + B = \n");
            funções.ImprimirMatriz(funções.SumMatriz(3, 3, matrizA, matrizB));
        }
        static void exercicio03()
        {
            //3. Maior e Menor Valor
            //Desenvolva um algoritmo que encontre o maior e o menor valor dentro de uma matriz.

            int[,] matrizA =
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 6, 7, 8, }
            };

           List<int> resposta = funções.MaioreMenor(matrizA);
           funções.ImprimirMatriz(matrizA);
           Console.WriteLine($"O menor número da matriz é {resposta[0]} e o maior numero da matriz é {resposta[1]}");
        }
        static void exercicio04() {
            //4. Diagonal Principal
            //Escreva um programa que exiba apenas os elementos da diagonal principal de uma matriz quadrada.
            int[,] matrizA =
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 6, 7, 8, }
            };
            funções.ImprimirMatriz(matrizA);
            Console.WriteLine("Sua matriz principal é ");
            funções.DiagonalPrincipal(matrizA);
        }
        static void exercicio05()
        {
            //5. Transposta de uma Matriz
            //Implemente um programa que gere a transposta de uma matriz 3x3.

            int[,] matrizA =
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 6, 7, 8, }
            };

            Console.WriteLine("Matriz A\n");
            funções.ImprimirMatriz(matrizA);
            Console.WriteLine("\nSua transposta é\n");
            funções.ImprimirMatriz(funções.Transposta(matrizA));
        }
        static void exercicio06()
        {
            //6. Matriz Identidade
            //Construa um programa que verifica se uma matriz quadrada é uma matriz identidade.

            int[,] matrizA =
            {
                { 1, 2, 3, },
                { 4, 5, 6, },
                { 6, 7, 8, }
            };
            int[,] matrizB =
            {
                { 1, 0, 0},
                { 0, 1, 0},
                { 0, 0, 1}
            };

            Console.WriteLine("Matriz A\n");
            funções.ImprimirMatriz(matrizA);

            if (funções.VerificaIdentidade(matrizA)) {
                Console.WriteLine("A matriz A é identidade");
            } else {
                Console.WriteLine("A matriz A não é uma matriz identidade");
             };

            Console.WriteLine("\nMatriz B\n");
            funções.ImprimirMatriz(matrizB);

            if (funções.VerificaIdentidade(matrizB))
            {
                Console.WriteLine("A matriz B é identidade");
            }
            else
            {
                Console.WriteLine("A matriz B não é uma matriz identidade");
            };
        }
        static void exercicio07()
        {
            //7. Multiplicação de Matrizes
            //Escreva um código que multiplica duas matrizes 2x2 e exibe o resultado.
            int[,] matrizA = { 
                { 1, 2 }, 
                { 3, 4 } 
            };
            int[,] matrizB = {
                { 5, 6 },
                { 7, 8 }
            };
            Console.WriteLine("Matriz A\n");
            funções.ImprimirMatriz(matrizA);
            Console.WriteLine("\nMatriz B\n");
            funções.ImprimirMatriz(matrizB);
            Console.WriteLine("\nMatriz A * Matriz B = \n");
            funções.ImprimirMatriz(funções.MultiplicacaoMatriz(matrizA, matrizB));
        }
        static void exercicio08()
        {
            //8. Média dos Elementos
            //Calcule a média dos valores armazenados em uma matriz 4x4.
            int[,] matrizA = {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };
            Console.WriteLine("Matriz");
            funções.ImprimirMatriz(matrizA);
            Console.WriteLine($"\nA media de seus valores é {funções.SumMatrizunica(4, 4, matrizA)/16}");
         
        }
        static void exercicio09()
        {
            int[,] matriz = {
                {0,0,0,0 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };
            // 9. Matriz Esparsa
            //Desenvolva um programa que verifica se uma matriz possui mais elementos nulos(0) do que não nulos.
            int[] resposta = funções.MatrizEsparsa(matriz);
            funções.ImprimirMatriz(matriz);
            Console.WriteLine($"\nHá {resposta[0]} elementos nulos e {resposta[1]} elementos não nulos.");
        }
        static void exercicio10()
        {
            /*10. Matriz Dinâmica
              Crie uma matriz de tamanho variável, solicite ao usuário os valores e exiba a matriz na tela.*/
            funções.ImprimirMatriz(funções.MatrizDinamica());
            Console.WriteLine("\nVocê construiu essa matriz.");
        }
    }
}
