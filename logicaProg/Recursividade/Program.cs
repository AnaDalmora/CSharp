using System.Runtime.Intrinsics.X86;

namespace Recursividade
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
        }


        static void exercicio01()
        {
            // Exercício 1: Potência
            //Implemente uma função recursiva chamada Potencia que recebe dois parâmetros base e expoente e calcula a potência de base elevado a expoente.
            try { 
            int a = funcoes.AskInt("Insira um número");
            int b = funcoes.AskInt("Insira a potência que você deseja elevar o numero");
            Console.WriteLine($"{a}^{b} = {funcoes.Potencia(a,b)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Insira apenas numeros inteiros");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

        }
        static void exercicio02()
        {
            //Exercício 2: Soma de Números Inteiros
            //Crie uma função recursiva chamada Soma que recebe um número inteiro positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n.
            try { 
            int n = funcoes.AskInt("Insira um número inteiro");
            Console.WriteLine($"A soma dos numeros entre 1 e {n} é {funcoes.Soma(n)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Insira apenas numeros inteiros");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
        static void exercicio03()
        {
            // Exercício 3: Fibonacci
            //Desenvolva uma função recursiva chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna o n - ésimo termo da sequência de Fibonacci.
            try
            {
                Console.WriteLine("Fibonacci de 5 termos:\n");
                funcoes.Fibonacci(0, 1, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
        static void exercicio04()
        {
            //Exercício 4: Contagem Regressiva
            //Escreva uma função recursiva chamada ContagemRegressiva que recebe um número inteiro positivo n como parâmetro e exibe uma
            //contagem regressiva de n até 1.
            try{ 
            int n = funcoes.AskInt("Insira um número para executar a contagem regressiva");
            funcoes.ContagemRegressiva(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Insira apenas numeros inteiros");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
        static void exercicio05()
        {
            //Exercício 5: Máximo Divisor Comum (MDC)
            //Crie uma função recursiva chamada MDC que recebe dois números inteiros positivos a e b
            //como parâmetros e retorna o máximo divisor comum entre eles.
            try
            {
                int a = funcoes.AskInt("Insira um A");
                int b = funcoes.AskInt("Insira um B");
                funcoes.MDC(a, b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Insira apenas numeros inteiros");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        
        }
    }
}
