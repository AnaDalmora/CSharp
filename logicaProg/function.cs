using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Funcoes
{
    public static void Main(System.String[] args)
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
        exercicio11();
        exercicio12();
        exercicio13();
        exercicio14();
        exercicio15();
        exercicio16();
        exercicio17();
        exercicio18();
        exercicio19();
        exercicio20();

    }
    static void exercicio01()
    {

        //1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
        try
        {
            double a = AskNumberDouble("Digite um número");
            double b = AskNumberDouble("Digite um número");
            Console.WriteLine($"A soma dos numeros {a} e {b} é equivalente a {soma(a, b)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato inválido, é aceito somente número");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }

    }
    static void exercicio02()
    {

        //2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
        try
        {
            int n = AskNumberInt("Digite um número inteiro");
            Console.WriteLine($"A fatorial do número {n} é {Fatorial(n)}");
        }
        catch(FormatException)
        {
            Console.WriteLine("é aceitado somente números inteiros");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio03()
    {
        //3. Desenvolva uma função que verifique se um número é primo ou não.
        try
        {
            int n = AskNumberInt("Digite um número inteiro");

            if (EhPrimo(n))
            {
                Console.WriteLine($"O número {n} é primo");
            }
            else
            {
                Console.WriteLine($"O número {n} não é primo");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número inteiro.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio04()
    {
        //4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
        try
        {
            List<int> numeros = new List<int>();
            int n = AskNumberInt("Insira um número (-1 para sair)");
            while (n != -1)
            {
                numeros.Add(n);
                n = AskNumberInt("Insira um número (-1 para sair)");
            }
            Console.WriteLine($"O maior número inserido é {numeros.Max()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio05()
    {

        //5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
        try
        {
            string str = Ask("Digite uma palavra: ");
            Console.WriteLine($"A palavra {str} ao contrário é {InverterString(str)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio06()
    {

        //6. Escreva uma função que calcule a média de uma lista de números reais.
        try
        {
            List<int> notas = new List<int>();
            int n = AskNumberInt("Insira um número (-1 para sair)");
            while (n != -1)
            {
                notas.Add(n);
                n = AskNumberInt("Insira um número (-1 para sair)");
            }
            Console.WriteLine($"A média das notas inserídas é {Media(notas)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio07()
    {

        //7.Desenvolva uma função que verifique se uma string é um palíndromo(ela lê o mesmo de trás para frente) ou não.
        try
        {
            string str = Ask("Digite uma palavra: ");

            if (str.ToUpper() == InverterString(str).ToUpper())
            {
                Console.WriteLine($"A palavra {str} é um palíndromo");
            }
            else
            {
                Console.WriteLine($"A palavra {str} não é um palíndromo");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio08()
    {

        //8.Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
        try
        {
            double grausC = AskNumberDouble("Insira o grau celsius para converter: ");
            Console.WriteLine($"{grausC}°C é {CtoFahrenheit(grausC)}° fahrenheit");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um numero");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio09()
    {


        //9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.7
        try
        {
            string[] palavras = { "ana", "julia", "estudando", "csharp" };

            for (int i = 0; i < palavras.Length; i++)
            {
                if (ContaCarac(palavras[i]) >= 5)
                {
                    Console.WriteLine($"A palavra {palavras[i]} possui {ContaCarac(palavras[i])} caracteres.");
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio10()
    {

        try
        {
            //10.Escreva uma função que calcule o máximo divisor comum(MDC) entre dois números inteiros.
            int a = AskNumberInt("Insira um número inteiro");
            int b = AskNumberInt("Insira um número inteiro");
            int mdc = MDC(a, b);
            Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número inteiro.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio11()
    {
        try
        {
            //11.Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
            List<int> numeros = new List<int>();
            int n = AskNumberInt("Insira um número (-1 para sair)");
            while (n != -1)
            {
                numeros.Add(n);
                n = AskNumberInt("Insira um número (-1 para sair)");
            }

            Console.Write($"Somente os numeros");
            foreach (int i in EhPar(numeros))
            {
                Console.Write($" {i} ");

            }
            Console.WriteLine("são pares");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio12()
    {

        //12.Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
        try
        {
            List<int> numeros = new List<int>();
            int n = AskNumberInt("Insira um número (-1 para sair)");
            while (n != -1)
            {
                numeros.Add(n);
                n = AskNumberInt("Insira um número (-1 para sair)");
            }
            int nDesejavelVer = AskNumberInt("Qual numero você deseja saber a quantidade de vezes aparece em uma lista?");
            Console.WriteLine($"O numero {nDesejavelVer} aparece {CountElementos(numeros, nDesejavelVer)} vezes");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }

    }
    static void exercicio13()
    {

        //13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.
        try
        {
            string str = Ask("Insira uma string em maiuscula ou minuscula");
            Console.WriteLine(ConverterString(str));
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio14()
    {
        try
        {
            //14.Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.
            int termo = AskNumberInt("Insira um termo para calcular o fibonacci");
            Console.WriteLine($"O Fibonacci do termo {termo} é {Fibonacci(termo)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número inteiro");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }


    }
    static void exercicio15()
    {

        //15. Desenvolva uma função que determine se um número é positivo, negativo ou zero.
        try
        {
            int numero = AskNumberInt("Insira um numero inteiro");
            Console.WriteLine($"O numero inserido é {VerificaNumero(numero)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número inteiro.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio16()
    {

        //16: Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.
        try
        {
            double n1 = AskNumberDouble("Insira um numero");
            double n2 = AskNumberDouble("Insira um numero");
            int operador = AskNumberInt("Qual operação deseja fazer?\n 1 - Soma\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão");
            Console.WriteLine($"Resultado: {Calculadora(n1, n2, operador)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static void exercicio17()
    {

        //17: Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.
        exercicio03();
    }
    static void exercicio18()
    {
        exercicio14();
    }
    static void exercicio19()
    {
        //19: Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.
        try
        {
            string n = Ask("Insira um numero inteiro");
            Console.WriteLine($"O numero {n} possui {ContarDigitos(n)} caracteres");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número inteiro");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }

    static void exercicio20()
    {
        //20: Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.
        try
        {
            double n1 = AskNumberDouble("Insira um numero");
            double n2 = AskNumberDouble("Insira um numero");
            double n3 = AskNumberDouble("Insira um numero");
            Console.WriteLine($"A média dos numeros é {CalcularMedia(n1, n2, n3)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um número");
        } catch(Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
    static double CalcularMedia(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }
    static int ContarDigitos(string n)
    {
        return n.Length;
    }
    static double Calculadora(double n1, double n2, int operador)
    {
        switch (operador)
        {
            case 1:
                return n1 + n2;
                break;
            case 2:
                return n1 - n2;
                break;
            case 3:
                return n1 * n2;
                break;
            case 4:
                return n1 / n2;
            default:
                return 0;
                break;
        }
    }
    static string VerificaNumero(int numero)
    {
        if (numero == 0)
        {
            return "Zero";
        }
        else if (numero > 0)
        {
            return "Positivo";
        }
        else
        {
            return "Negativo";
        }
    }
    static int Fibonacci(int termo)
    {
        int termoAntecessor = 0;
        int termoAtual = 1;
        int fibonacci = 0;
        for (int i = 3; i <= termo; i++)
        {
            fibonacci = termoAtual + termoAntecessor;
            termoAntecessor = termoAtual;
            termoAtual = fibonacci;
        }
        return fibonacci;
    }
    static string ConverterString(string str)
    {
        string minuscula = str.ToLower();
        if (str == minuscula)
        {
            return str.ToUpper();
        }
        else
        {
            return minuscula;
        }

    }
    static int CountElementos(List<int> lista, int n)
    {
        int vezesApareceu = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] == n)
            {
                vezesApareceu++;
            }
        }
        return vezesApareceu;
    }
    static double soma(double x, double y)
    {
        return x + y;
    }
    static double AskNumberDouble(string pergunta)
    {
        Console.WriteLine(pergunta);
        return double.Parse(Console.ReadLine());
    }
    static int AskNumberInt(string pergunta)
    {
        Console.WriteLine(pergunta);
        return int.Parse(Console.ReadLine());
    }
    static string Ask(string pergunta)
    {
        Console.WriteLine(pergunta);
        return Console.ReadLine();
    }
    static int Fatorial(int x)
    {
        int fat = 1;
        for (int i = x; i > 1; i--)
        {
            fat *= i;
        }
        return fat;
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
    static int MaiorNumero(List<int> lista)
    {
        return lista.Max();
    }
    static string InverterString(string str)
    {
        int qtdCaracter = str.Length - 1;
        string strNew = "";

        for (int i = qtdCaracter; i >= 0; i--)
        {
            strNew += str[i];
        }
        return strNew;
    }
    static double Media(List<int> lista)
    {
        double sum = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            sum += lista[i];
        }

        return sum / lista.Count;
    }
    static double CtoFahrenheit(double grausC)
    {
        return grausC * 1.8 + 32;
    }
    static int ContaCarac(string palavra)
    {
        return palavra.Length;
    }
    static List<int> EhPar(List<int> numeros)
    {
        List<int> pares = new List<int>();

        for (int i = 0; i < numeros.Count(); i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares.Add(numeros[i]);
            }

        }

        return pares;
    }

    static int MDC(int a, int b)
    {
        while (b != 0)
        {
            int n = b;
            b = a % b;
            a = n;
        }
        return a;
    }

}